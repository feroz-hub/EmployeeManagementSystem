namespace EMS.Application.Services.Interfaces;

public interface ISalaryService
{
    Task<decimal> CalculateSalary(Employee employee);
    Task StoreSalary(Employee employee, decimal netSalary);
}