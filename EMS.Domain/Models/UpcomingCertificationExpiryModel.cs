namespace EMS.Domain.Models;

public class UpcomingCertificationExpiryModel
{
    public Guid CertificationId { get; set; }
    public Guid EmployeeId { get; set; }
    public string CertificationName { get; set; }
    public string IssuingOrganization { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string EmployeeName { get; set; }
}