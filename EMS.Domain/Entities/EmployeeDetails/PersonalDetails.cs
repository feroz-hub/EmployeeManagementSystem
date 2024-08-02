namespace EMS.Domain.Entities.EmployeeDetails;

public class PersonalDetails
{
    [Key]
    [ForeignKey("Employee")]
    public Guid Id { get; set; }

    [Required]
    public string Address { get; set; }
    
    [Required]
    public string PhoneNumber { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    [Required]
    public DateTime DateOfBirth { get; set; }

    public Employee Employee { get; set; }
}
