namespace EMS.Domain.Entities.EmployeeDetails;
public class Certification
{
    [Key]
    public Guid CertificationId { get; set; }
    public Guid EmployeeId { get; set; }
    public string CertificationName { get; set; }
    public string IssuingOrganization { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? ExpiryDate { get; set; }

    public Employee Employee { get; set; }
}

