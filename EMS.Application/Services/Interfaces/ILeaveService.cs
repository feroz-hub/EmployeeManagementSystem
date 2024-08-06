using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface ILeaveService
{
    Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(Guid employeeId);
    Task<Leave> GetLeaveByIdAsync(Guid id);
    Task AddLeaveAsync(Guid employeeId,LeaveModel leaveModel);
    Task UpdateLeaveAsync(Guid employeeId,LeaveModel leaveModel);
    Task<bool> DeleteLeaveAsync(Guid id);
}