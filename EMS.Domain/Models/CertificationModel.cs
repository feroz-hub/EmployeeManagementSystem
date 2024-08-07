namespace EMS.Domain.Models;

public class CertificationModel
{
    
    public string CertificationName { get; set; }
    public string IssuingOrganization { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
}