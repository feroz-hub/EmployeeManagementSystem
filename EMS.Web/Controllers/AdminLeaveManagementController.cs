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
    public async Task<IActionResult> UpdateStatus(LeaveModel model)
    {
        if (ModelState.IsValid)
        {
            await leaveService.UpdateLeaveStatusAsync(model.Id,model);
            return RedirectToAction("Index"); // Redirect to the list page or appropriate page
        }
        return View("Index"); // Or appropriate view in case of an error
    }

    
}