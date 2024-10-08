namespace EMS.Domain.Entities;

public class EmployeeSalary
{
    [Key ,ForeignKey("Employee")]
    public Guid EmployeeId { get; set; }
    public decimal NetSalary { get; set; }
    public string Band { get; set; }
    public DateTime CalculatedOn { get; set; }
    public Employee? Employee { get; set; }
}
