namespace EMS.Domain.Entities.EmployeeDetails;
public class Qualification
{
    [Key]
    public Guid QualificationId { get; set; }
    public Guid EmployeeId { get; set; }
    public string Degree { get; set; }
    public string Institution { get; set; }
    public DateTime GraduationDate { get; set; }
    public string Grade { get; set; }
    public Employee? Employee { get; set; }
}

