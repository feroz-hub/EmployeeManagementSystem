namespace EMS.Domain.Report;

public class EmployeeReport
{
    public string EmployeeName { get; set; }
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }
    public List<QualificationReport> QualificationsReports { get; set; }
    public List<ExperienceReport> ExperiencesReports { get; set; }
}