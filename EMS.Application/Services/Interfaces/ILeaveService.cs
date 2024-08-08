using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface ILeaveService
{
    Task<IEnumerable<LeaveModel>> GetLeavesByEmployeeIdAsync(Guid employeeId);
    Task<LeaveModel> GetLeaveByIdAsync(Guid id);
    Task AddLeaveAsync(Guid employeeId, LeaveModel leaveModel);
    Task UpdateLeaveAsync(Guid employeeId, LeaveModel leaveModel);
    Task<bool> DeleteLeaveAsync(Guid id);
    Task<int> GetTotalLeaveAppliedAsync();
    Task<int> GetPendingLeaveRequest();
    Task<List<RecentLeaveRequestModel>> GetRecentLeaveRequestAsync();
    Task<List<LeaveStatusUpdateViewModel>> GetAllLeaveStatusAsync();
    Task UpdateLeaveStatusAsync(Guid leaveId, LeaveModel leaveModel );

}