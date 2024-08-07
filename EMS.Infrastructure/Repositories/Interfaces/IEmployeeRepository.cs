using EMS.Domain.Models;

namespace EMS.Infrastructure.Repositories.Interfaces;

public interface IEmployeeRepository:IGenericRepository<Employee>
{
    Task<int> GetTotalEmployeesAsync();
    Task<Dictionary<string, int>> GetEmployeesByDepartment();
    Task<Dictionary<string, int>> GetEmployeesByType();
    Task<IEnumerable<Employee>> RecentEmployee();
}