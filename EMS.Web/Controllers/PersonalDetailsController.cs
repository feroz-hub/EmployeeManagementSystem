using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

public class PersonalDetailsController(IPersonalDetailsService personalDetailsService) : Controller
{
    // GET
    public async Task<IActionResult> Edit(Guid employeeId)
    {
        var personalDetails = await personalDetailsService.GetPersonalDetailsByEmployeeIdAsync(employeeId);
        if (personalDetails==null)
        {
            return NotFound();
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditPersonalDetails", personalDetails);

    }
    [HttpPost]
    public async Task<IActionResult> Edit(Guid employeeId, PersonalDetailsModel personalDetails)
    {
        if (ModelState.IsValid)
        {
            await personalDetailsService.UpdatePersonalDetailsAsync(employeeId, personalDetails);
            return RedirectToAction("Details", "Employee",new {id=employeeId});
        }

        return PartialView("_EditPersonalDetails", personalDetails);
    }
}