namespace EMS.Domain.Models;

public class RecentLeaveRequestModel
{
    public Guid LeaveId { get; set; }
    public string EmployeeName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public DateTime? RequestDate { get; set; }
    public int DaysRequested { get; set; }
}