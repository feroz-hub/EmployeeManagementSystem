namespace EMS.Domain.Entities.EmployeeDetails;
public class GovernmentDocument
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string DocumentType { get; set; }
    
    [Required]
    public string DocumentNumber { get; set; }
    
    [Required]
    public DateTime IssueDate { get; set; }
    
    [Required]
    public DateTime ExpiryDate { get; set; }
    
    [ForeignKey("Employee")]
    public Guid EmployeeId { get; set; }
    
    public Employee Employee { get; set; }
}
