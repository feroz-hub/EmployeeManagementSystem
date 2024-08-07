namespace EMS.Web.Models;

public class DashBoardViewModel
{
    public int TotalEmployees { get; set; }
    public Dictionary<string, int> EmployeesByDepartment { get; set; }
    public Dictionary<string, int> EmployeesByType { get; set; }
    public int TotalLeavesApplied { get; set; }
    public int PendingLeaveRequests { get; set; }
    public decimal AverageEmployeeSalary { get; set; }
    public List<EmployeeModel> RecentEmployees { get; set; }
    public List<LeaveModel> RecentLeaveRequests { get; set; }
    public List<CertificationModel> UpcomingCertificationsExpiry { get; set; }
}