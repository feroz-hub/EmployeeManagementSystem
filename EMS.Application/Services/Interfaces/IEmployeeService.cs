using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IEmployeeService
{
   
    Task<IEnumerable<EmployeeModel>> GetAllEmployeesAsync();
    Task<EmployeeModel> GetEmployeeByIdAsync(Guid id);
    Task AddEmployeeAsync(EmployeeModel employeeModel);
    Task UpdateEmployeeAsync(EmployeeModel employee);
    Task<bool> DeleteEmployeeAsync(Guid id);
    Task<int> GetTotalEmployeesAsync();
    Task<Dictionary<string, int>> GetEmployeesByDepartmentAsync();
    Task<Dictionary<string, int>> GetEmployeesByTypeAsync();
    Task <List<EmployeeModel>> RecentEmployeesAsync();
}