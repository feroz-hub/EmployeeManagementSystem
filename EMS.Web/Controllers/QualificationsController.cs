
namespace EMS.Web.Controllers;

public class QualificationsController(IQualificationService qualificationService) : Controller
{
    // GET
    public IActionResult  Create(Guid employeeId)
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
            TempData["success"] = "Qualification added successfully.";
            return RedirectToAction("Details", "Employee", new { id = qualification.EmployeeId });
        }
        
        TempData["error"] = "Failed to add qualification.";
        return PartialView("_CreateQualification", qualification);
    }
    
    // GET: Qualifications/Edit/5
    public async Task<IActionResult> Edit(Guid id, Guid employeeId)
    {
        var qualification = await qualificationService.GetQualificationByIdAsync(id);
        if (qualification == null)
        {
            TempData["error"] = "Qualification not found.";
            return RedirectToAction("Error", "Home");
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
            TempData["success"] = "Qualification updated successfully.";
            // Redirect to the employee details page
            return RedirectToAction("Details", "Employee", new { id = employeeId });
        }

        // Return to the partial view if the model state is invalid
        ViewBag.EmployeeId = employeeId;
        TempData["error"] = "Failed to update qualification.";
        return PartialView("_EditQualification", qualification);
    }
    
    // GET: Qualifications/Delete/{id}
    public async Task<IActionResult> Delete(Guid id, Guid employeeId)
    {
        var qualification = await qualificationService.GetQualificationByIdAsync(id);
        if (qualification == null)
        {
            TempData["error"] = "Qualification not found.";
            return RedirectToAction("Error", "Home");
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
        TempData["success"] = "Qualification deleted successfully.";
        return RedirectToAction("Details", "Employee", new { id = employeeId });
    }

}