namespace EMS.Domain.Entities;

// EMS.Domain/Entities/Report.cs
public class Report
{
    // Unique identifier for the report
    public Guid Id { get; set; }
    
    // Title of the report
    public string Title { get; set; }
    
    // Date and time when the report was generated
    public DateTime GeneratedOn { get; set; }
    
    // Content or body of the report
    public string Content { get; set; }
    
    // Foreign key for the associated department
    public Guid DepartmentId { get; set; }
    
    // Navigation property to the related Department entity
    public Department Department { get; set; }
}
