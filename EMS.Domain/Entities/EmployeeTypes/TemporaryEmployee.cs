namespace EMS.Domain.Entities.EmployeeTypes;

public class TemporaryEmployee:EmployeeBase
{
    public decimal Salary { get; set; }
    public override decimal CalculateNetSalary()
    {
        return Salary;
    }
}