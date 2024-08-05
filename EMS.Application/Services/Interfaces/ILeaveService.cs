namespace EMS.Application.Services.Interfaces;

public interface ILeaveService
{
    Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(Guid employeeId);
    Task<Leave> GetLeaveByIdAsync(Guid id);
    Task AddLeaveAsync(Leave leave);
    Task UpdateLeaveAsync(Leave leave);
    Task<bool> DeleteLeaveAsync(Guid id);
}