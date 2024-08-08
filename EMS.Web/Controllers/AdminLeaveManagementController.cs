using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

public class AdminLeaveManagementController(ILeaveService leaveService) : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var leaveStatusViewModel = await leaveService.GetAllLeaveStatusAsync();
        return View(leaveStatusViewModel);
    }
    [HttpPost]
    public async Task<IActionResult> UpdateStatus(Guid leaveId, LeaveStatus status)
    {
        await leaveService.UpdateLeaveStatusAsync(leaveId, status);
        return RedirectToAction("Index");
    }
}