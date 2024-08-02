namespace EMS.Domain.Entities.EmployeeDetails;

// EMS.Domain/Entities/Certification.cs
public class Certification
{
    // Unique identifier for the certification
    public int Id { get; set; }
    
    // Name of the certification
    public string CertificationName { get; set; }
    
    // Name of the organization that issued the certification
    public string IssuingOrganization { get; set; }
    
    // Date when the certification was issued
    public DateTime IssueDate { get; set; }
    
    // Date when the certification expires
    public DateTime ExpiryDate { get; set; }
    
    // Foreign key for the associated employee
    public int EmployeeId { get; set; }
    
    // Navigation property to the related Employee entity
    public Employee Employee { get; set; }
}
