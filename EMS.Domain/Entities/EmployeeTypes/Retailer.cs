namespace EMS.Domain.Entities.EmployeeTypes;

public class Retailer:EmployeeBase
{
    public decimal BasicSalary { get; set; }
    public decimal DearnessAllowance { get; set; }
    public override decimal CalculateNetSalary()
    {
        return BasicSalary + DearnessAllowance;
    }
}