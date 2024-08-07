using EMS.Domain.Models;

namespace EMS.Application.Services.Interfaces;

public interface IEmployeeSalaryService
{
    Task<EmployeeSalaryModel> GetEmployeeSalary(Guid employeeId);
    Task<decimal> AverageEmployeeSalaryAsync();
    Task CalculateAndStoreSalary(Guid employeeId);
    Task CalculateAndStoreSalariesForAllEmployees(); // New method
}