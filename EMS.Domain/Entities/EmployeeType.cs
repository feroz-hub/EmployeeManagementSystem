namespace EMS.Domain.Entities;

public class EmployeeType
{
    public Guid EmployeeTypeId { get; set; }
    public EmpTypes EmpTypes { get; set; }
    
    public ICollection<Employee> Employees { get; set; }
}
public enum EmpTypes
{
    Permanent,
    Temporary,
    Retailer,
    Intern
}