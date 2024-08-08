using EMS.Domain.Entities;

namespace EMS.Domain.Models;

public class LeaveStatusUpdateViewModel
{
    public Guid EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public List<LeaveUpdateModel> Leaves { get; set; }
    
}
public class LeaveUpdateModel
{
    public Guid LeaveId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public LeaveStatus Status { get; set; } // e.g., "Approved", "Rejected", "Pending"
    public int TotalDays { get; set; }
    
}