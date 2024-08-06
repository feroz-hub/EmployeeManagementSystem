namespace EMS.Domain.Models;

public class GovernmentDocumentModel
{
    public DocumentType DocumentType { get; set; }
    public string DocumentNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpiryDate { get; set; }
}