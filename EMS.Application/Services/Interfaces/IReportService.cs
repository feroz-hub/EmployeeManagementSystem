namespace EMS.Application.Services.Interfaces;

public interface IReportService
{
    Task<List<DepartmentReport>> GetDepartmentReportsAsync();
    void GenerateDepartmentReport(List<DepartmentReport> departmentReports, string filePath); 
    void GenerateDepartmentReportPdf(List<DepartmentReport> departmentReports,Stream stream);
}