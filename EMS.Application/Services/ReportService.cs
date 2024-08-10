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
                        EndDate = ex.EndDate.HasValue ? ex.EndDate.Value : (DateTime?)null
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
        
        using var document = new PdfDocument();
        var departmentNumber = 1;

        foreach (var department in departmentReports)
        {
            var page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
            XFont headerFont = new XFont("Verdana", 10, XFontStyle.Bold);
            XFont departmentFont = new XFont("Verdana", 12, XFontStyle.Bold);

            double yPoint = 40;
            double xPoint = 20;
            double tablePadding = 5;
            double rowHeight = 20;

            // Add Department Name with Number
            gfx.DrawString($"{departmentNumber}. {department.Department}", departmentFont, XBrushes.Black,
                new XRect(xPoint, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
            yPoint += 40;

            // Define column widths
            double[] columnWidths = { 40, 160, 200, 100 };

            // Table Headers
            DrawTableCell(gfx, "No.", xPoint, yPoint, columnWidths[0], rowHeight, headerFont, true);
            DrawTableCell(gfx, "Employee Name", xPoint + columnWidths[0], yPoint, columnWidths[1], rowHeight,
                headerFont, true);
            DrawTableCell(gfx, "Job Title", xPoint + columnWidths[0] + columnWidths[1], yPoint, columnWidths[2],
                rowHeight, headerFont, true);
            DrawTableCell(gfx, "Salary", xPoint + columnWidths[0] + columnWidths[1] + columnWidths[2], yPoint,
                columnWidths[3], rowHeight, headerFont, true, true); // Right-align salary

            yPoint += rowHeight; // Move to the next row

            int employeeNumber = 1;
            foreach (var employee in department.EmployeeReports)
            {
                // Employee Details Row with numbering
                DrawTableCell(gfx, employeeNumber.ToString(), xPoint, yPoint, columnWidths[0], rowHeight, font);
                DrawTableCell(gfx, employee.EmployeeName, xPoint + columnWidths[0], yPoint, columnWidths[1], rowHeight,
                    font);
                DrawTableCell(gfx, employee.JobTitle, xPoint + columnWidths[0] + columnWidths[1], yPoint,
                    columnWidths[2], rowHeight, font);
                DrawTableCell(gfx, employee.Salary.ToString("C"),
                    xPoint + columnWidths[0] + columnWidths[1] + columnWidths[2], yPoint, columnWidths[3], rowHeight,
                    font, false, true); // Right-align salary

                yPoint += rowHeight; // Move to the next row

                // Qualifications Table Header
                DrawTableCell(gfx, "Qualifications", xPoint, yPoint, columnWidths.Sum(), rowHeight, headerFont, true);
                yPoint += rowHeight;

                foreach (var qualification in employee.QualificationsReports)
                {
                    // Qualifications Rows
                    DrawTableCell(gfx,
                        $"{qualification.Degree} ({qualification.Institution}, {qualification.GraduationDate.ToShortDateString()})",
                        xPoint + tablePadding, yPoint, columnWidths.Sum() - tablePadding * 2, rowHeight, font);
                    yPoint += rowHeight;
                }

                // Experiences Table Header
                DrawTableCell(gfx, "Experiences", xPoint, yPoint, columnWidths.Sum(), rowHeight, headerFont, true);
                yPoint += rowHeight;

                foreach (var experience in employee.ExperiencesReports)
                {
                    // Experiences Rows
                    DrawTableCell(gfx,
                        $"{experience.JobTitle} at {experience.CompanyName} ({experience.StartDate.ToShortDateString()} - {(experience.EndDate.HasValue ? experience.EndDate.Value.ToShortDateString() : "Present")})",
                        xPoint + tablePadding, yPoint, columnWidths.Sum() - tablePadding * 2, rowHeight, font);
                    yPoint += rowHeight;
                }

                yPoint += 20; // Add some space before the next employee
                employeeNumber++;

                // Check if we need a new page
                if (yPoint + 40 > page.Height)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    yPoint = 40;
                }
            }

            departmentNumber++;
            yPoint += 60; // Add some space before the next department
        }


        document.Save(stream);
        return;

        // Function to draw a cell with a border
        void DrawTableCell(XGraphics gfx, string text, double x, double y, double width, double height, XFont font,
            bool isHeader = false, bool rightAlign = false)
        {
            if (isHeader)
            {
                gfx.DrawRectangle(XBrushes.LightGray, x, y, width, height);
            }

            gfx.DrawRectangle(XPens.Black, x, y, width, height);
            var format = rightAlign ? XStringFormats.TopRight : XStringFormats.TopLeft;
            gfx.DrawString(text, font, XBrushes.Black,
                new XRect(x + (rightAlign ? -5 : 5), y + 5, width - 10, height - 10), format);
        }
    }
}
