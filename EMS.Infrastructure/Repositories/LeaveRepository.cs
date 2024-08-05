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
}