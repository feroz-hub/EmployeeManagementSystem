using EMS.Domain.Models;
using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class LeaveRepository(ApplicationDbContext context) :GenericRepository<Leave>(context),ILeaveRepository
{
    public async Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(Guid employeeId)
    {
        return await context.Leaves
            .Where(l => l.EmployeeId == employeeId)
            .ToListAsync();
    }

    public async Task<int> GetTotalLeavesAppliedAsync()
    {
        return await context.Leaves.CountAsync();
    }

    public async Task<int> GetTotalLeavesPendingAsync()
    {
        return await context.Leaves
            .Where(l => l.Status == LeaveStatus.Requested)
            .CountAsync();
    }

    public async Task<IEnumerable<Leave>> RecentLeaveRequests()
    {
        DateTime recentThreshold = DateTime.Now.AddDays(-30);
        return await context.Leaves
            .Where(l => l.RequestDate >= recentThreshold)
            .ToListAsync();
    }
}