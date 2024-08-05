namespace EMS.Domain.Entities;

// EMS.Domain/Entities/Department.cs
public class Department
{
    // Unique identifier for the department
    public Guid Id { get; set; }
    
    // Name of the department
    public string Name { get; set; }
    
    // List of employees in the department
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
