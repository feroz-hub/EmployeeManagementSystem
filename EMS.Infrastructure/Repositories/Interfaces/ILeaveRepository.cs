using EMS.Domain.Models;

namespace EMS.Infrastructure.Repositories.Interfaces;

public interface ILeaveRepository:IGenericRepository<Leave>
{
    Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(Guid employeeId);
    Task<int> GetTotalLeavesAppliedAsync();
    Task<int> GetTotalLeavesPendingAsync();

    Task<List<RecentLeaveRequestModel>> RecentLeaveRequests();
    Task<List<LeaveStatusUpdateViewModel>> GetAllLeaveStatusAsync();
    Task UpdateLeaveStatusAsync(int leaveId, LeaveStatus status);
}