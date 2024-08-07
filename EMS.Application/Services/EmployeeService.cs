using AutoMapper;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class EmployeeService(IUnitOfWork unitOfWork,IMapper mapper) : IEmployeeService
{
    public async Task<IEnumerable<EmployeeModel>> GetAllEmployeesAsync()
    {
        var employees= await unitOfWork.Employees.GetAllAsync();
        return mapper.Map<IEnumerable<EmployeeModel>>(employees);
    }
    
    public async Task<EmployeeModel> GetEmployeeByIdAsync(Guid id)
    {
       var employee= await unitOfWork.Employees.GetByIdAsync(id);
       return mapper.Map<EmployeeModel>(employee);
       
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
        employeeData.CreatedAt=DateTime.Now;
        // Add the Employee entity
        await unitOfWork.Employees.AddAsync(employeeData);
    }

    public async Task UpdateEmployeeAsync(EmployeeModel employeeModel)
    {
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeModel.EmployeeId);
        if (employee == null)
        {
            throw new Exception("Employee not found");
        }
        mapper.Map(employeeModel, employee);
        await unitOfWork.Employees.UpdateAsync(employee);
        await unitOfWork.CompleteAsync();
    }
    
    public async Task<bool> DeleteEmployeeAsync(Guid id)
    {
      return  await unitOfWork.Employees.DeleteAsync(id);
    }

    public async Task<int> GetTotalEmployeesAsync()
    {
        return await unitOfWork.Employees.GetTotalEmployeesAsync();
    }

    public async Task<Dictionary<string, int>> GetEmployeesByDepartmentAsync()
    {
        return await unitOfWork.Employees.GetEmployeesByDepartment();
    }

    public async Task<Dictionary<string, int>> GetEmployeesByTypeAsync()
    {
        return await unitOfWork.Employees.GetEmployeesByType();
    }

    

    public async Task<List<EmployeeModel>> RecentEmployeesAsync()
    {
        var employees = await unitOfWork.Employees.RecentEmployee();
        return mapper.Map<List<EmployeeModel>>(employees);
    }
}