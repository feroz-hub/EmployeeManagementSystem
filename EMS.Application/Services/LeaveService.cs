using AutoMapper;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class LeaveService(IUnitOfWork unitOfWork,IMapper mapper):ILeaveService
{
    public async Task<IEnumerable<LeaveModel>> GetLeavesByEmployeeIdAsync(Guid employeeId)
    {
        var leaves= await unitOfWork.Leaves.GetLeavesByEmployeeIdAsync(employeeId);
        return mapper.Map<IEnumerable<LeaveModel>>(leaves);
        
    }

    public async Task<LeaveModel> GetLeaveByIdAsync(Guid id)
    { 
        var leave=await unitOfWork.Leaves.GetByIdAsync(id);
        return mapper.Map<LeaveModel>(leave);
    }

    public async Task AddLeaveAsync(Guid employeeId,LeaveModel leaveModel)
    {
        // Check if the employee exists
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }
        var leave = new Leave
        {
            EmployeeId = employeeId,
            StartDate = leaveModel.StartDate,
            EndDate = leaveModel.EndDate,
            Reason = leaveModel.Reason,
            RequestDate = DateTime.Today,
            Status = LeaveStatus.Requested
        };
        await unitOfWork.Leaves.AddAsync(leave);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateLeaveAsync(Guid employeeId,LeaveModel leaveModel)
    {
        var leave = await unitOfWork.Leaves.GetByIdAsync(employeeId);
        if (leave == null)
        {
            throw new Exception("Leave does not exist.");
        }
        leave.StartDate = leaveModel.StartDate;
        leave.EndDate = leaveModel.EndDate;
        leave.Reason = leaveModel.Reason;
        leave.RequestDate = leaveModel.RequestDate;
        await unitOfWork.Leaves.UpdateAsync(leave);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteLeaveAsync(Guid id)
    {
        return await unitOfWork.Leaves.DeleteAsync(id);
        
    }

    public async Task<int> GetTotalLeaveAppliedAsync()
    {
        return await unitOfWork.Leaves.GetTotalLeavesAppliedAsync();
    }

    public async Task<int> GetPendingLeaveRequest()
    {
        return await unitOfWork.Leaves.GetTotalLeavesPendingAsync();
    }

    public async Task<List<RecentLeaveRequestModel>> GetRecentLeaveRequestAsync()
    {
         return await unitOfWork.Leaves.RecentLeaveRequests();
        
    }

    public async Task<List<LeaveStatusUpdateViewModel>> GetAllLeaveStatusAsync()
    {
        return await unitOfWork.Leaves.GetAllLeaveStatusAsync();
    }

    public async Task UpdateLeaveStatusAsync(Guid leaveId, LeaveModel leaveModel)
    {
        // Retrieve the leave request from the database
        var leave = await unitOfWork.Leaves.GetByIdAsync(leaveId);
        if (leave == null)
        {
            throw new Exception("Leave request not found.");
        }
        // Update the leave status
        leave.StartDate = leaveModel.StartDate;
        leave.EndDate = leaveModel.EndDate;
        leave.Reason = leaveModel.Reason;
        leave.Status = leaveModel.LeaveStatus;
        await unitOfWork.Leaves.UpdateAsync(leave);
        await unitOfWork.CompleteAsync();
    }
}