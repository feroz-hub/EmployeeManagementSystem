namespace EMS.Domain.Entities.EmployeeTypes;

public class PermanentEmployee:EmployeeBase
{
    public decimal BasicSalary { get; set; }
    public decimal DearnessAllowance { get; set; }
    public decimal HRA { get; set; }
    public decimal ConveyanceAllowance { get; set; }
    public decimal EntertainmentAllowance { get; set; }
    public decimal MedicalInsurance { get; set; }
    
    
    public override decimal CalculateNetSalary()
    {
        return BasicSalary + DearnessAllowance + HRA + ConveyanceAllowance + EntertainmentAllowance + MedicalInsurance;
    }
}