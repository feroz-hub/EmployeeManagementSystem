namespace EMS.Domain.Models;

public class QualificationModel
{
    public Guid QualificationId { get; set; }
    public Guid EmployeeId { get; set; }
    public string Degree { get; set; }
    public string Institution { get; set; }
    public DateTime GraduationDate { get; set; }
    public string Grade { get; set; }
}