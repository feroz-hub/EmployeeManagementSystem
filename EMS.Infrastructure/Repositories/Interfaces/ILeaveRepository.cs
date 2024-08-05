namespace EMS.Infrastructure.Repositories.Interfaces;

public interface ILeaveRepository:IGenericRepository<Leave>
{
    Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(Guid employeeId);
}