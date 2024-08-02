namespace EMS.Domain.Entities;

public class EmployeeType
{
    [Key]
    public Guid EmployeeTypeId { get; set; }
    public EmpTypes EmpTypes { get; set; }
}
public enum EmpTypes
{
    Permanent,
    Temporary,
    Retailer,
    Intern
}