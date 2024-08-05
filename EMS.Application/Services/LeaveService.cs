using EMS.Infrastructure.Repositories.Interfaces;

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

    public async Task AddLeaveAsync(Leave leave)
    {
        await unitOfWork.Leaves.AddAsync(leave);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateLeaveAsync(Leave leave)
    {
        await unitOfWork.Leaves.UpdateAsync(leave);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteLeaveAsync(Guid id)
    {
        return await unitOfWork.Leaves.DeleteAsync(id);
        
    }
}