namespace EMS.Domain.Entities;


public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Employee> Employees { get; set; }
    public ICollection<Report> Reports { get; set; }
}

public enum DepartmentType
{
    Administration,
    HR,
    Finance,
    Marketing,
    Sales,
    IT
}
