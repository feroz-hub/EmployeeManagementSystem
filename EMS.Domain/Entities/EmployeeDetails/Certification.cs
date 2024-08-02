namespace EMS.Domain.Entities.EmployeeDetails;
public class Certification
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string CertificationName { get; set; }
    
    [Required]
    public string IssuingOrganization { get; set; }
    
    [Required]
    public DateTime IssueDate { get; set; }
    
    [Required]
    public DateTime ExpiryDate { get; set; }
    
    [ForeignKey("Employee")]
    public Guid EmployeeId { get; set; }
    
    public Employee Employee { get; set; }
}
