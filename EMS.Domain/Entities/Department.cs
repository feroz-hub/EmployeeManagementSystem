namespace EMS.Domain.Entities;

// EMS.Domain/Entities/Department.cs
public class Department
{
    // Unique identifier for the department
    public int Id { get; set; }
    
    // Name of the department
    public string Name { get; set; }
    
    // List of employees in the department
    public List<Employee> Employees { get; set; }
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
