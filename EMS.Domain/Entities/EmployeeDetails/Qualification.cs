namespace EMS.Domain.Entities.EmployeeDetails;

// EMS.Domain/Entities/Qualification.cs
public class Qualification
{
    [Key]
    // Unique identifier for the qualification
    public Guid Id { get; set; }
    
    // The degree or qualification obtained (e.g., BSc, MSc, PhD)
    public string Degree { get; set; }
    
    // The institution where the qualification was obtained
    public string Institution { get; set; }
    
    // The date when the employee graduated or obtained the qualification
    public DateTime GraduationDate { get; set; }
    
    // The grade or classification obtained for the qualification (e.g., First Class)
    public string Grade { get; set; }
    
    // Foreign key for the associated employee
    public int EmployeeId { get; set; }
    
    // Navigation property to the related Employee entity
    public Employee Employee { get; set; }
}
