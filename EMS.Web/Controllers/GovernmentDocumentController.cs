using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

public class GovernmentDocumentController(IGovernmentDocumentService governmentDocumentService): Controller
{
    // GET
    public IActionResult Create(Guid employeeId)
    {
        ViewBag.EmployeeId = employeeId;
        return PartialView("_CreateGovernmentDocument");
    }
    [HttpPost]
    public async Task<IActionResult> Create(GovernmentDocumentModel governmentDocument)
    {
        if (ModelState.IsValid)
        {
            await governmentDocumentService.AddGovernmentDocumentAsync(governmentDocument.EmployeeId,governmentDocument);
            TempData["success"] = "Government document added successfully.";
            return RedirectToAction("Details", "Employee",new {id=governmentDocument.EmployeeId});
        }
        TempData["error"] = "Failed to add government document.";
        return PartialView("_CreateGovernmentDocument",governmentDocument);
    }
    
    public async Task<IActionResult> Edit(Guid id,Guid employeeId)
    {
        var  governmentDocument = await governmentDocumentService.GetGovernmentDocumentByIdAsync(id);
        if (governmentDocument == null)
        {
            TempData["error"] = "Government document not found.";
            return RedirectToAction("Error", "Home");
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditGovernmentDocument", governmentDocument);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid employeeId,GovernmentDocumentModel governmentDocument)
    {
        if (ModelState.IsValid)
        {
            await governmentDocumentService.UpdateGovernmentDocumentAsync(governmentDocument.DocumentId,governmentDocument);
            TempData["success"] = "Government document updated successfully.";
            return RedirectToAction("Details", "Employee", new {id=governmentDocument.EmployeeId});
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditGovernmentDocument", governmentDocument);
    }

    //GET : GovernmentDocument/Delete/{id}
    public async Task<IActionResult> Delete(Guid id, Guid EmployeeId)
    {
        var governmentDocumentModel = await governmentDocumentService.GetGovernmentDocumentByIdAsync(id);
        if (governmentDocumentModel == null)
        {
            TempData["error"] = "Government document not found.";
            return RedirectToAction("Error", "Home");
        }
        ViewBag.EmployeeId = EmployeeId;
        return PartialView("_DeleteGovernmentDocument", governmentDocumentModel);
    }
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid documentId, Guid employeeId)
    {
        await governmentDocumentService.DeleteGovernmentDocumentAsync(documentId);
        TempData["success"] = "Government document deleted successfully.";
        return RedirectToAction("Details", "Employee", new {id=employeeId});
    }
}