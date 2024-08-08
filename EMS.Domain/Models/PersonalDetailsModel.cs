namespace EMS.Domain.Models;

public class PersonalDetailsModel
{
    public Guid EmployeeId { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
}