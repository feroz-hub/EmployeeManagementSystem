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
}
