namespace EMS.Domain.Entities;

// EMS.Domain/Entities/Leave.cs
public class Leave
{
    // Unique identifier for the leave entry
    public Guid Id { get; set; }
    
    // Start date of the leave period
    public DateTime StartDate { get; set; }
    
    // End date of the leave period
    public DateTime EndDate { get; set; }
    
    // Reason for taking leave
    public string Reason { get; set; }
    
    // Status of the leave request
    public LeaveStatus Status { get; set; }
    
    // Foreign key for the associated employee
    public Guid EmployeeId { get; set; }
    
    // Navigation property to the related Employee entity
    public Employee Employee { get; set; }
}

// Enumeration representing the status of a leave request
public enum LeaveStatus
{
    Requested,  // Leave has been requested but not yet approved
    Approved,   // Leave has been approved
    Rejected,   // Leave request has been rejected
    Cancelled   // Leave has been cancelled
}
