namespace EMS.Domain.Entities.EmployeeDetails;

public class Experience
{
    [Key] public Guid ExperienceId { get; set; }
    public Guid EmployeeId { get; set; }
    public string CompanyName { get; set; }
    public string JobTitle { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Responsibilities { get; set; }

    public Employee? Employee { get; set; }
}


