using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class ReportService(IUnitOfWork unitOfWork):IReportService
{
    public async Task<IEnumerable<Report>> GetReportsByDepartmentIdAsync(Guid departmentId)
    {
        return await unitOfWork.Reports.GetReportsByDepartmentIdAsync(departmentId);
    }

    public async Task<Report> GetReportByIdAsync(Guid id)
    {
        return await unitOfWork.Reports.GetByIdAsync(id);
    }

    public async Task AddReportAsync(Report report)
    {
        await unitOfWork.Reports.AddAsync(report);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateReportAsync(Report report)
    {
        await unitOfWork.Reports.UpdateAsync(report);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteReportAsync(Guid id)
    {
        return await unitOfWork.Reports.DeleteAsync(id);
    }
}