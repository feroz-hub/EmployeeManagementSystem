namespace EMS.Domain.Entities.EmployeeDetails;

// EMS.Domain/Entities/Experience.cs
public class Experience
{
    // Unique identifier for the experience entry
    public int Id { get; set; }
    
    // Name of the company where the experience was gained
    public string CompanyName { get; set; }
    
    // Job title or position held at the company
    public string JobTitle { get; set; }
    
    // Start date of the employment period
    public DateTime StartDate { get; set; }
    
    // End date of the employment period (can be null if still employed)
    public DateTime EndDate { get; set; }
    
    // Description of the responsibilities held during the employment
    public string Responsibilities { get; set; }
    
    // Foreign key for the associated employee
    public int EmployeeId { get; set; }
    
    // Navigation property to the related Employee entity
    public Employee Employee { get; set; }
}
