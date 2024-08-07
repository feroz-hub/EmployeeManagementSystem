namespace EMS.Web.Controllers;
public class CertificationController(ICertificationService certificationService) : Controller
{
    // GET
    public IActionResult  Create(Guid employeeId)
    {
        ViewBag.EmployeeId = employeeId;
        return PartialView("_CreateCertificate");
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Guid employeeId,CertificationModel certificationModel)
    {
        if (!ModelState.IsValid) return PartialView("_CreateCertificate", certificationModel);
        await certificationService.AddCertificationAsync(employeeId,certificationModel);
        return RedirectToAction("Details", "Employee", new { id = certificationModel.EmployeeId });
    }
    
    // GET: Certification/Edit/5
    public async Task<IActionResult> Edit(Guid id, Guid employeeId)
    {
        var certification = await certificationService.GetCertificationByIdAsync(id);
        if (certification == null)
        {
            return NotFound();
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditCertificate", certification);
    }
    
    // POST: Certification/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid employeeId, CertificationModel certification)
    {
        if (ModelState.IsValid)
        {
            // Ensure the certification has the correct EmployeeId
            certification.EmployeeId = employeeId;
            // Update the certification in the repository
            await certificationService.UpdateCertificationAsync(certification.CertificationId, certification);
            // Redirect to the employee details page
            return RedirectToAction("Details", "Employee", new { id = employeeId });
        }

        // Return to the partial view if the model state is invalid
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditCertificate", certification);
    }
    // GET : Certification/Delete/{id}
    
    public async Task<IActionResult> Delete(Guid id, Guid employeeId)
    {
        var certification = await certificationService.GetCertificationByIdAsync(id);
        if (certification == null)
        {
            return NotFound();
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_DeleteCertificate", certification);
    }

    // POST: Certification/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id, Guid employeeId)
    {
        await certificationService.DeleteCertificationAsync(id);
        return RedirectToAction("Details", "Employee", new { id = employeeId });
    }
    
}
