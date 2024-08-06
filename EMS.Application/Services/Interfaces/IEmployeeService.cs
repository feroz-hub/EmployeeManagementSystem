using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IEmployeeService
{
    Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    Task<Employee> GetEmployeeByIdAsync(Guid id);
    Task AddEmployeeAsync(EmployeeModel employeeModel);
    Task UpdateEmployeeAsync(EmployeeModel employee);
    Task<bool> DeleteEmployeeAsync(Guid id);
}