namespace EMS.Domain.Entities.EmployeeDetails;

// EMS.Domain/Entities/Qualification.cs
public class Qualification
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Degree { get; set; }
    
    [Required]
    public string Institution { get; set; }
    
    [Required]
    public DateTime GraduationDate { get; set; }
    
    [Required]
    public string Grade { get; set; }

    [ForeignKey("Employee")]
    public Guid EmployeeId { get; set; }
    
    public Employee Employee { get; set; }
}

