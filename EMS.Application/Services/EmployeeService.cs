using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class EmployeeService(IUnitOfWork unitOfWork) : IEmployeeService
{
    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    {
        return await unitOfWork.Employees.GetAllAsync();
    }

    public async Task<Employee> GetEmployeeByIdAsync(Guid id)
    {
       return await unitOfWork.Employees.GetByIdAsync(id);
    }

    public async Task AddEmployeeAsync(Employee employee)
    {
        await unitOfWork.Employees.AddAsync(employee);
        await unitOfWork.CompleteAsync();
    }

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        await unitOfWork.Employees.UpdateAsync(employee);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteEmployeeAsync(Guid id)
    {
      return  await unitOfWork.Employees.DeleteAsync(id);
    }
}