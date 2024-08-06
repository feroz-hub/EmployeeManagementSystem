namespace EMS.Domain.Entities.EmployeeDetails;

public class PersonalDetails
{
    [Key, ForeignKey("Employee")]
    public Guid EmployeeId { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Employee? Employee { get; set; }
}

