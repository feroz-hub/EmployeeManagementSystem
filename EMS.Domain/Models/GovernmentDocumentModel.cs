namespace EMS.Domain.Models;

public class GovernmentDocumentModel
{
    public Guid EmployeeId { get; set; }
    public Guid DocumentId { get; set; }
    public DocumentType DocumentType { get; set; }
    public string DocumentNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
}