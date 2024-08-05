namespace EMS.Infrastructure.Repositories.Interfaces;

public interface IReportRepository:IGenericRepository<Report>
{
    Task<IEnumerable<Report>> GetReportsByDepartmentIdAsync(Guid departmentId);
}