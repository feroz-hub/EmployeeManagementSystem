using AutoMapper;
using EMS.Domain.Models;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class EmployeeService(IUnitOfWork unitOfWork,IMapper mapper) : IEmployeeService
{
    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    {
        return await unitOfWork.Employees.GetAllAsync();
    }
    public async Task<Employee> GetEmployeeByIdAsync(Guid id)
    {
       return await unitOfWork.Employees.GetByIdAsync(id);
    }

    public async Task AddEmployeeAsync(EmployeeModel employeeDataModel)
    {
        // Generate a new EmployeeId
        var employeeDataId = Guid.NewGuid();

        // Map EmployeeDto to Employee entity and set the EmployeeId
        var employeeData = mapper.Map<Employee>(employeeDataModel);
        employeeData.EmployeeId = employeeDataId;

        // Set EmployeeId for related entities
        foreach (var qualification in employeeData.Qualifications)
        {
            qualification.EmployeeId = employeeData.EmployeeId;
        }
        foreach (var experience in employeeData.Experiences)
        {
            experience.EmployeeId = employeeData.EmployeeId;
        }
        foreach (var document in employeeData.GovernmentDocuments)
        {
            document.EmployeeId = employeeData.EmployeeId;
        }
        foreach (var certification in employeeData.Certifications)
        {
            certification.EmployeeId = employeeData.EmployeeId;
        }

        if (employeeData.PersonalDetails != null)
        {
            employeeData.PersonalDetails.EmployeeId = employeeData.EmployeeId;
        }
        employeeData.SetBand();
        // Add the Employee entity
        await unitOfWork.Employees.AddAsync(employeeData);
    }

    public async Task UpdateEmployeeAsync(EmployeeModel employee)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateEmployeeAsync(Employee employeeData)
    {
        await unitOfWork.Employees.UpdateAsync(employeeData);
        await unitOfWork.CompleteAsync();
    }

    public async Task<bool> DeleteEmployeeAsync(Guid id)
    {
      return  await unitOfWork.Employees.DeleteAsync(id);
    }
}