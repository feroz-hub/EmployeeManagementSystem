using EMS.Domain.Entities;

namespace EMS.Domain.Models;

public class LeaveModel
{
    public Guid EmployeeId { get; set; }
    public Guid Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime? RequestDate { get; set; }
    public LeaveStatus LeaveStatus { get; set; }
    public string Reason { get; set; }
   
}