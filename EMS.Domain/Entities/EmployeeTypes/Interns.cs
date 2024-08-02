namespace EMS.Domain.Entities.EmployeeTypes;

public class Interns:EmployeeBase 
{
    public decimal Stipend { get; set; }
    public override decimal CalculateNetSalary()
    {
        return Stipend;
    }
}