namespace EMS.Domain.Entities.EmployeeDetails;
public class GovernmentDocument
{
    [Key]
    public Guid DocumentId { get; set; }
    public Guid EmployeeId { get; set; }
    public string DocumentType { get; set; }
    public string DocumentNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public Employee Employee { get; set; }
}

