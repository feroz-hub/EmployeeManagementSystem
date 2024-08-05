using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class ReportRepository(ApplicationDbContext context) :GenericRepository<Report>(context),IReportRepository
{
    public async Task<IEnumerable<Report>> GetReportsByDepartmentIdAsync(Guid departmentId)
    {
        return await context.Reports
            .Where(r => r.DepartmentId == departmentId)
            .ToListAsync();
    }
}