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
            return RedirectToAction("Details", "Employee", new { id = leaveModel.EmployeeId });
        }

        return PartialView("_ApplyLeave", leaveModel);
    }
    
    // GET: /Leave/CancelLeave
    public IActionResult CancelLeave(Guid id,Guid employeeId)
    {
        var leave = leaveService.GetLeaveByIdAsync(id).Result; // Use async properly in real code
        if (leave == null)
        {
            return NotFound();
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
            return RedirectToAction("Details", "Employee", new { id = employeeId });
    }

}