using EMS.Domain.Entities;

namespace EMS.Domain.Models;

public class LeaveModel
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public LeaveStatus Status { get; set; }
}