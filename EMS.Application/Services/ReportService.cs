namespace EMS.Application.Services;

public class ReportService(ApplicationDbContext context) : IReportService
{
    public async Task<List<DepartmentReport>> GetDepartmentReportsAsync()
    {
        var departments = await context.Employees
            .Include(e => e.Qualifications)
            .Include(e => e.Experiences)
            .Include(e => e.EmployeeSalary)
            .ToListAsync();
        var departmentsReports = departments
            .GroupBy(e => e.DepartmentType)
            .Select(g => new DepartmentReport()
            {
                Department = g.Key.ToString(),
                EmployeeReports = g.Select(e => new EmployeeReport()
                {
                    EmployeeName = e.Name,
                    JobTitle = e.Experiences.OrderByDescending(ex => ex.StartDate).FirstOrDefault()?.JobTitle ?? "N/A",
                    Salary = e.EmployeeSalary?.NetSalary ?? 0,
                    QualificationsReports = e.Qualifications.Select(q => new QualificationReport()
                    {
                        Degree = q.Degree,
                        Institution = q.Institution,
                        GraduationDate = q.GraduationDate
                    }).ToList(),
                    ExperiencesReports = e.Experiences.Select(ex => new ExperienceReport()
                    {
                        CompanyName = ex.CompanyName,
                        JobTitle = ex.JobTitle,
                        StartDate = ex.StartDate,
                        EndDate = ex.EndDate.HasValue ? ex.EndDate.Value:(DateTime?)null
                    }).ToList()
                }).ToList()
            }).ToList();
        return departmentsReports;
    }

    public void GenerateDepartmentReport(List<DepartmentReport> departmentReports, string filePath)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using ExcelPackage package = new ExcelPackage();
        foreach (var department in departmentReports)
        {
            var worksheet = package.Workbook.Worksheets.Add(department.Department);
            int row = 1;

            // Add Headers
            worksheet.Cells[row, 1].Value = "Employee Name";
            worksheet.Cells[row, 2].Value = "Job Title";
            worksheet.Cells[row, 3].Value = "Salary";
            worksheet.Cells[row, 4].Value = "Qualifications";
            worksheet.Cells[row, 5].Value = "Experiences";

            row++;

            foreach (var employee in department.EmployeeReports)
            {
                worksheet.Cells[row, 1].Value = employee.EmployeeName;
                worksheet.Cells[row, 2].Value = employee.JobTitle;
                worksheet.Cells[row, 3].Value = employee.Salary;

                // Add Qualifications
                var qualifications = string.Join(", ",
                    employee.QualificationsReports.Select(q =>
                        $"{q.Degree} ({q.Institution}, {q.GraduationDate.ToShortDateString()})"));
                worksheet.Cells[row, 4].Value = qualifications;

                // Add Experiences
                var experiences = string.Join(", ",
                    employee.ExperiencesReports.Select(e =>
                        $"{e.JobTitle} at {e.CompanyName} ({e.StartDate.ToShortDateString()} - {(e.EndDate.HasValue ? e.EndDate.Value.ToShortDateString() : "Present")})"));
                worksheet.Cells[row, 5].Value = experiences;

                row++;
            }

            // Auto-fit columns
            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
            worksheet.Cells[1, 1, 1, 5].Style.Font.Bold = true;
        }

        // Save to file
        FileInfo fileInfo = new FileInfo(filePath);
        package.SaveAs(fileInfo);
    }

    public void GenerateDepartmentReportPdf(List<DepartmentReport> departmentReports, Stream stream)
        {
            // // Get the program's current directory
            // string programDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //
            // // Define the new folder name
            // string folderName = "Reports";
            //
            // // Combine the program directory with the new folder name to create the path
            // string reportsFolderPath = Path.Combine(programDirectory, folderName);
            //
            // // Ensure the directory exists (creates it if it doesn't exist)
            // if (!Directory.Exists(reportsFolderPath))
            // {
            //     Directory.CreateDirectory(reportsFolderPath);
            // }
            //
            // // Specify the full file path (within the new folder)
            // string filePath = Path.Combine(reportsFolderPath, "DepartmentReport.pdf");

            using PdfDocument document = new PdfDocument();
            foreach (var department in departmentReports)
            {
                var page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 12, XFontStyle.Regular);
                int yPoint = 40;

                // Add Department Name
                gfx.DrawString(department.Department, font, XBrushes.Black, new XRect(20, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                yPoint += 40;

                foreach (var employee in department.EmployeeReports)
                {
                    // Add Employee Details
                    gfx.DrawString($"Employee Name: {employee.EmployeeName}", font, XBrushes.Black, new XRect(20, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Job Title: {employee.JobTitle}", font, XBrushes.Black, new XRect(20, yPoint + 20, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Salary: {employee.Salary}", font, XBrushes.Black, new XRect(20, yPoint + 40, page.Width, page.Height), XStringFormats.TopLeft);

                    yPoint += 80;

                    // Add Qualifications
                    gfx.DrawString("Qualifications:", font, XBrushes.Black, new XRect(20, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                    yPoint += 20;
                    foreach (var qualification in employee.QualificationsReports)
                    {
                        gfx.DrawString($"{qualification.Degree} ({qualification.Institution}, {qualification.GraduationDate.ToShortDateString()})", font, XBrushes.Black, new XRect(40, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20;
                    }

                    // Add Experiences
                    gfx.DrawString("Experiences:", font, XBrushes.Black, new XRect(20, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                    yPoint += 20;
                    foreach (var experience in employee.ExperiencesReports)
                    {
                        gfx.DrawString($"{experience.JobTitle} at {experience.CompanyName} ({experience.StartDate.ToShortDateString()} - {(experience.EndDate.HasValue ? experience.EndDate.Value.ToShortDateString() : "Present")})", font, XBrushes.Black, new XRect(40, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20;
                    }

                    yPoint += 40; // Add some space before the next employee
                }
            }

            document.Save(stream);
        }
}
