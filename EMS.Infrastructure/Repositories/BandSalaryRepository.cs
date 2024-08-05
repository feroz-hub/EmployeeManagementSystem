using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class BandSalaryRepository(ApplicationDbContext context) :GenericRepository<BandSalary>(context),IBandSalaryRepository
{
    public async Task<BandSalary> GetBandSalaryByBandAndDepartment(string band, DepartmentType departmentType)
    {
        return await context.BandSalaries.FirstOrDefaultAsync(bs =>
            bs.Band == band && bs.DepartmentType == departmentType);
    }
}