using AutoMapper;
using EMS.Domain.Enums;
using EMS.Domain.Models;

namespace EMS.Application.Services;

public class EmployeeSalaryService(IUnitOfWork unitOfWork,IMapper mapper):IEmployeeSalaryService
{
    

    public async Task<EmployeeSalaryModel> GetEmployeeSalary(Guid employeeId)
    {
        var employeeSalary= await unitOfWork.EmployeeSalary.GetByIdAsync(employeeId);
        return mapper.Map<EmployeeSalaryModel>(employeeSalary);
    }

    public async Task CalculateAndStoreSalary(Guid employeeId)
    {
        // Check if the employee exists
        var employee = await unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new Exception("Employee does not exist.");
        }
    
        var bandSalary = await unitOfWork.BandSalary.GetBandSalaryByBandAndDepartment(employee.Band, employee.DepartmentType);
        if (bandSalary == null)
        {
            throw new Exception("Band salary details not found.");
        }

        decimal netSalary = 0;
        var employeeType = employee.EmployeeType;

        switch (employeeType)
        {
            case EmployeeType.Permanent:
                netSalary = bandSalary.BasicSalary + bandSalary.DearnessAllowance + bandSalary.HRA +
                            bandSalary.ConveyanceAllowance + bandSalary.EntertainmentAllowance +
                            bandSalary.MedicalInsurance;
                break;
            case EmployeeType.Temporary:
                netSalary = bandSalary.BasicSalary + bandSalary.DearnessAllowance;
                break;
            case EmployeeType.Retailer:
                netSalary = bandSalary.BasicSalary + bandSalary.DearnessAllowance;
                break;
            case EmployeeType.Intern:
                netSalary = bandSalary.Stipend;
                break;
        }

        var employeeSalary = new EmployeeSalary
        {
            EmployeeId = employee.EmployeeId,
            NetSalary = netSalary,
            Band = employee.Band,
            CalculatedOn = DateTime.Now
        };

        await unitOfWork.EmployeeSalary.AddAsync(employeeSalary);
        await unitOfWork.CompleteAsync();
    }

}