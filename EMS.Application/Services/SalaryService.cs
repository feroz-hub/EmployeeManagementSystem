using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Application.Services;

public class SalaryService(IUnitOfWork unitOfWork):ISalaryService
{
    public async Task<decimal> CalculateSalary(Employee employee)
    {
        var bandSalary =
            await unitOfWork.BandSalaryRepository.GetBandSalaryByBandAndDepartment(employee.Band,
                employee.DepartmentType);
        if (bandSalary == null)
        {
            throw new Exception("Band salary details not found.");
        }

        decimal netSalary = 0;
        var employeeType = employee.EmployeeType.EmpTypes;

        switch (employeeType)
        {
            case EmpTypes.Permanent:
                netSalary = bandSalary.BasicSalary + bandSalary.DearnessAllowance + bandSalary.HRA +
                            bandSalary.ConveyanceAllowance + bandSalary.EntertainmentAllowance +
                            bandSalary.MedicalInsurance;
                break;
            case EmpTypes.Temporary:
                netSalary = bandSalary.BasicSalary + bandSalary.DearnessAllowance;
                break;
            case EmpTypes.Retailer:
                netSalary = bandSalary.BasicSalary + bandSalary.DearnessAllowance;
                break;
            case EmpTypes.Intern:
                netSalary = bandSalary.Stipend;
                break;
        }

        return netSalary;
    }

    public async Task StoreSalary(Employee employee, decimal netSalary)
    {
        var employeeSalary = new EmployeeSalary
        {
            EmployeeId = employee.EmployeeId,
            NetSalary = netSalary,
            Band = employee.Band,
            CalculatedOn = DateTime.Now
        };

        await unitOfWork.EmployeeSalaryRepository.AddAsync(employeeSalary);
        await unitOfWork.CompleteAsync();
    }
}