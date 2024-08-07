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

    public async Task<int> GetTotalEmployeesAsync()
    {
        return await context.Employees.CountAsync();
    }

    public async Task<Dictionary<string, int>> GetEmployeesByDepartment()
    {
        return await context.Employees
            .GroupBy(e => e.DepartmentType)
            .Select(group => new { Department = group.Key, Count = group.Count() })
            .ToDictionaryAsync(g => g.Department.ToString(), g => g.Count);
    }

    public async Task<Dictionary<string, int>> GetEmployeesByType()
    {
        return await context.Employees
            .GroupBy(e => e.EmployeeType)
            .Select(group => new { EmployeeType = group.Key, Count = group.Count() })
            .ToDictionaryAsync(g => g.EmployeeType.ToString(), g => g.Count);
    }

    public async Task<IEnumerable<Employee>> RecentEmployee()
    {
        DateTime recentThreshold = DateTime.Now.AddDays(-30);
        return await context.Employees
            .Where(e => e.CreatedAt >= recentThreshold)
            .Include(e => e.PersonalDetails)
            .Include(e => e.Qualifications)
            .Include(e => e.Experiences)
            .Include(e => e.GovernmentDocuments)
            .Include(e => e.Certifications)
            .Include(e => e.EmployeeSalary)
            .Include(e => e.Leaves)
            .ToListAsync();
    }
}