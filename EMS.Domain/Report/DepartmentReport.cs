namespace EMS.Domain.Report;

public class DepartmentReport
{
    public string Department { get; set; }
    public List<EmployeeReport> EmployeeReports { get; set; }
}