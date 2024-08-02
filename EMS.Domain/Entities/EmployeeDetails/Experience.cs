namespace EMS.Domain.Entities.EmployeeDetails;

public class Experience
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string CompanyName { get; set; }
    
    [Required]
    public string JobTitle { get; set; }
    
    [Required]
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    [Required]
    public string Responsibilities { get; set; }
    
    [ForeignKey("Employee")]
    public Guid EmployeeId { get; set; }
    
    public Employee Employee { get; set; }
}

