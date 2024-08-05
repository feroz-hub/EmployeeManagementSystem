namespace EMS.Domain.Entities;

public class BandSalary
{
    public Guid Id { get; set; }
    public string Band { get; set; }
    public DepartmentType DepartmentType { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal DearnessAllowance { get; set; }
    public decimal HRA { get; set; }
    public decimal ConveyanceAllowance { get; set; }
    public decimal EntertainmentAllowance { get; set; }
    public decimal MedicalInsurance { get; set; }
    public decimal Stipend { get; set; }
}
