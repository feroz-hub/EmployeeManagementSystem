namespace EMS.Application.Services.Interfaces;

public interface IReportService
{
    Task<IEnumerable<Report>> GetReportsByDepartmentIdAsync(Guid departmentId);
    Task<Report> GetReportByIdAsync(Guid id);
    Task AddReportAsync(Report report);
    Task UpdateReportAsync(Report report);
    Task<bool> DeleteReportAsync(Guid id);
}