 using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

public class LeaveController(ILeaveService leaveService) : Controller
{
    // GET
    public IActionResult ApplyLeave(Guid employeeId)
    {
        ViewBag.EmployeeId = employeeId;
        return PartialView("_ApplyLeave");
    }
    // POST: /Leave/ApplyLeave
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ApplyLeave(Guid employeeId, LeaveModel leaveModel)
    {
        if (ModelState.IsValid)
        {
            await leaveService.AddLeaveAsync(employeeId, leaveModel);
            TempData["success"] = "Leave applied successfully.";
            return RedirectToAction("Details", "Employee", new { id = leaveModel.EmployeeId });
        }
        TempData["error"] = "Failed to apply leave.";
        return PartialView("_ApplyLeave", leaveModel);
    }
    
    // GET: /Leave/CancelLeave
    public IActionResult CancelLeave(Guid id,Guid employeeId)
    {
        var leave = leaveService.GetLeaveByIdAsync(id).Result; // Use async properly in real code
        if (leave == null)
        {
            TempData["error"] = "Leave not found.";
            return RedirectToAction("Error", "Home");
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_CancelLeave", leave);
    }

    // POST: /Leave/CancelLeave
    [HttpPost,ActionName("CancelLeave")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CancelLeaveConfirmed(Guid id, Guid employeeId)
    {
            await leaveService.DeleteLeaveAsync(id);
            TempData["success"] = "Leave canceled successfully.";
            return RedirectToAction("Details", "Employee", new { id = employeeId });
    }

}