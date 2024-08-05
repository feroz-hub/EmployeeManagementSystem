using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class EmployeeRepository(ApplicationDbContext context) :GenericRepository<Employee>(context),IEmployeeRepository
{
    public override Task<Employee> GetByIdAsync(Guid id)
    {
        return base.GetByIdAsync(id);
    }
}