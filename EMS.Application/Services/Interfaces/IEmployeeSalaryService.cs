namespace EMS.Application.Services.Interfaces;

public interface IEmployeeSalaryService
{
    Task<EmployeeSalary> GetEmployeeSalary(Guid employeeId);
    Task CalculateAndStoreSalary(Guid employeeId);
}