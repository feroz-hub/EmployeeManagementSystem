using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class EmployeeRepository(ApplicationDbContext context) :GenericRepository<Employee>(context),IEmployeeRepository
{
    public override async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await context.Employees.Include(e => e.PersonalDetails)
            .Include(e => e.Qualifications)
            .Include(e => e.Experiences)
            .Include(e => e.GovernmentDocuments)
            .Include(e => e.Certifications)
            .Include(e=>e.EmployeeSalary)
            .Include(e=>e.Leaves).ToListAsync();
    }

    public override async Task<Employee> GetByIdAsync(Guid id)
    {
        return await context.Employees
            .Include(e => e.PersonalDetails)
            .Include(e => e.Qualifications)
            .Include(e => e.Experiences)
            .Include(e => e.GovernmentDocuments)
            .Include(e => e.Certifications)
            .Include(e=>e.EmployeeSalary)
            .Include(e=>e.Leaves)
            .FirstOrDefaultAsync(e => e.EmployeeId == id);
    }
}