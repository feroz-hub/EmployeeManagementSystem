namespace EMS.Domain.Entities;


public class Leave
{
    public Guid Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public LeaveStatus Status { get; set; } 
    public Guid EmployeeId { get; set; }
    public Employee? Employee { get; set; }
}
public enum LeaveStatus
{
    Requested, 
    Approved,  
    Rejected,   
    Cancelled  
}
