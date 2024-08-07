namespace EMS.Infrastructure.Repositories.Interfaces;

public interface IEmployeeSalaryRepository:IGenericRepository<EmployeeSalary>
{
    Task<decimal> AverageEmployeeSalary();
}