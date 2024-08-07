
using EMS.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

public class QualificationsController(IQualificationService qualificationService,IMapper mapper) : Controller
{
    // GET
    public async Task<IActionResult>  Create(Guid employeeId)
    {
        ViewBag.EmployeeId = employeeId;
        return PartialView("_CreateQualification");
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Guid employeeId,QualificationModel qualification)
    {
        if (ModelState.IsValid)
        {
            await qualificationService.AddQualificationAsync(employeeId,qualification);
            return RedirectToAction("Details", "Employee", new { id = qualification.EmployeeId });
        }
        return PartialView("_CreateQualification", qualification);
    }
    
    // GET: Qualifications/Edit/5
    public async Task<IActionResult> Edit(Guid id, Guid employeeId)
    {
        var qualification = await qualificationService.GetQualificationByIdAsync(id);
        if (qualification == null)
        {
            return NotFound();
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditQualification", qualification);
    }
    
    // POST: Qualifications/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid employeeId, QualificationModel qualification)
    {
        if (ModelState.IsValid)
        {
            // Ensure the qualification has the correct EmployeeId
            qualification.EmployeeId = employeeId;
        
            // Update the qualification in the repository
            await qualificationService.UpdateQualificationAsync(qualification.QualificationId, qualification);

            // Redirect to the employee details page
            return RedirectToAction("Details", "Employee", new { id = employeeId });
        }

        // Return to the partial view if the model state is invalid
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditQualification", qualification);
    }
    
    // GET: Qualifications/Delete/{id}
    public async Task<IActionResult> Delete(Guid id, Guid employeeId)
    {
        var qualification = await qualificationService.GetQualificationByIdAsync(id);
        if (qualification == null)
        {
            return NotFound();
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_DeleteQualification", qualification);
    }

    
// POST: Qualifications/Delete
    [HttpPost,ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id, Guid employeeId)
    {
        await qualificationService.DeleteQualificationAsync(id);
        return RedirectToAction("Details", "Employee", new { id = employeeId });
    }

}