using EMS.Domain.Entities;

namespace EMS.Domain.Models;

public class LeaveModel
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public LeaveStatus Status { get; set; }
}