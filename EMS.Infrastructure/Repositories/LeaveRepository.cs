using EMS.Domain.Models;
using EMS.Infrastructure.Data;
using EMS.Infrastructure.Repositories.Interfaces;

namespace EMS.Infrastructure.Repositories;

public class LeaveRepository(ApplicationDbContext context) :GenericRepository<Leave>(context),ILeaveRepository
{
    public async Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(Guid employeeId)
    {
        return await context.Leaves
            .Where(l => l.EmployeeId == employeeId)
            .ToListAsync();
    }

    public async Task<int> GetTotalLeavesAppliedAsync()
    {
        return await context.Leaves.CountAsync();
    }

    public async Task<int> GetTotalLeavesPendingAsync()
    {
        return await context.Leaves
            .Where(l => l.Status == LeaveStatus.Requested)
            .CountAsync();
    }

    public async Task<List<RecentLeaveRequestModel>> RecentLeaveRequests()
    {
        DateTime recentThreshold = DateTime.Now.AddDays(-30);

        var recentLeaves = await (from leave in context.Leaves
                join employee in context.Employees
                    on leave.EmployeeId equals employee.EmployeeId
                where leave.RequestDate >= recentThreshold
                select new 
                {
                    leave.Id,
                    EmployeeName = employee.Name,
                    leave.StartDate,
                    leave.EndDate,
                    leave.Reason,
                    leave.RequestDate
                })
            .AsNoTracking()  // Optional: To optimize the query performance
            .ToListAsync();

        var recentLeaveRequestModels = recentLeaves.Select(leave => new RecentLeaveRequestModel
        {
            LeaveId = leave.Id,
            EmployeeName = leave.EmployeeName,
            StartDate = leave.StartDate,
            EndDate = leave.EndDate,
            Reason = leave.Reason,
            RequestDate = leave.RequestDate,
            DaysRequested = (leave.EndDate - leave.StartDate).Days + 1
        }).ToList();

        return recentLeaveRequestModels;
    }

    public async Task<List<LeaveStatusUpdateViewModel>> GetAllLeaveStatusAsync()
    {
        return await context.Employees
            .Select(employee => new LeaveStatusUpdateViewModel
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.Name,
                Leaves = employee.Leaves.Select(leave => new LeaveUpdateModel
                {
                    LeaveId = leave.Id,
                    StartDate = leave.StartDate,
                    EndDate = leave.EndDate,
                    Reason = leave.Reason,
                    Status = leave.Status,
                    TotalDays = (leave.EndDate - leave.StartDate).Days + 1
                }).ToList()
            })
            .ToListAsync();
    }


    public async Task UpdateLeaveStatusAsync(Guid leaveId, LeaveStatus status)
    {
       
        
        var leave = await context.Leaves.FindAsync(leaveId);
        if (leave != null)
        {
            leave.Status = status;
            await context.SaveChangesAsync();
        }
    }
}