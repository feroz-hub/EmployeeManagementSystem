using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class EmployeeSalaryRepository(ApplicationDbContext context) :GenericRepository<EmployeeSalary>(context),IEmployeeSalaryRepository
{
    public async Task<decimal> AverageEmployeeSalary()
    {
        var salaries = await context.EmployeeSalaries.Select(es => es.NetSalary).ToListAsync();
        return salaries.Count > 0 ? salaries.Average() : 0;
    }
}