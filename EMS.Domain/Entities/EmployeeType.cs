namespace EMS.Domain.Entities;

public class EmployeeType
{
    [Key]
    public int EmployeeTypeId { get; set; }
    public EmpTypes EmpTypes { get; set; }
}