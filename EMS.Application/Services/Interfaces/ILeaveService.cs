using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface ILeaveService
{
    Task<IEnumerable<LeaveModel>> GetLeavesByEmployeeIdAsync(Guid employeeId);
    Task<LeaveModel> GetLeaveByIdAsync(Guid id);
    Task AddLeaveAsync(Guid employeeId,LeaveModel leaveModel);
    Task UpdateLeaveAsync(Guid employeeId,LeaveModel leaveModel);
    Task<bool> DeleteLeaveAsync(Guid id);
}