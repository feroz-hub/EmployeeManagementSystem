namespace EMS.Domain.Models;

public class ExperienceModel
{
    public Guid EmployeeId { get; set; }
    public Guid ExperienceId { get; set; }
    public string CompanyName { get; set; }
    public string JobTitle { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Responsibilities { get; set; }
}