using EMS.Domain.Models;

namespace EMS.Application.Services;

public class LeaveService(IUnitOfWork unitOfWork):ILeaveService
{
    public async Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(Guid employeeId)
    {
        return await unitOfWork.Leaves.GetLeavesByEmployeeIdAsync(employeeId);
    }

    public async Task<Leave> GetLeaveByIdAsync(Guid id)
    {
        return await unitOfWork.Leaves.GetByIdAsync(id);
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
        await unitOfWork.Leaves.UpdateAsync(leave);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteLeaveAsync(Guid id)
    {
        return await unitOfWork.Leaves.DeleteAsync(id);
        
    }
}