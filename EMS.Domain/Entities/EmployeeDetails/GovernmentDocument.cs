namespace EMS.Domain.Entities.EmployeeDetails;

// EMS.Domain/Entities/GovernmentDocument.cs
public class GovernmentDocument
{
    // Unique identifier for the government document
    public int Id { get; set; }
    
    // Type of the document (e.g., Passport, ID Card, Driver's License)
    public string DocumentType { get; set; }
    
    // Unique number or identifier of the document
    public string DocumentNumber { get; set; }
    
    // Date when the document was issued
    public DateTime IssueDate { get; set; }
    
    // Date when the document expires
    public DateTime ExpiryDate { get; set; }
    
    // Foreign key for the associated employee
    public int EmployeeId { get; set; }
    
    // Navigation property to the related Employee entity
    public Employee Employee { get; set; }
}
