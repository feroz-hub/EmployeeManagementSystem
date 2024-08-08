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
            return RedirectToAction("Details", "Employee",new {id=governmentDocument.EmployeeId});
        }
        return PartialView("_CreateGovernmentDocument",governmentDocument);
    }
    
    public async Task<IActionResult> Edit(Guid id,Guid employeeId)
    {
        var  governmentDocument = await governmentDocumentService.GetGovernmentDocumentByIdAsync(id);
        if (governmentDocument == null)
        {
            return NotFound();
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
            return RedirectToAction("Details", "Employee", new {id=governmentDocument.EmployeeId});
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditGovernmentDocument", governmentDocument);
    }

    //GET : GovernmentDocument/Delete/{id}
    public async Task<IActionResult> Delete(Guid documentId, Guid EmployeeId)
    {
        var governmentDocumentModel = await governmentDocumentService.GetGovernmentDocumentByIdAsync(documentId);
        if (governmentDocumentModel == null)
        {
            return NotFound();
        }
        ViewBag.EmployeeId = EmployeeId;
        return PartialView("_DeleteGovernmentDocument", governmentDocumentModel);
    }
    [HttpPost,ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid documentId, Guid employeeId)
    {
        await governmentDocumentService.DeleteGovernmentDocumentAsync(documentId);
        return RedirectToAction("Details", "Employee", new {id=employeeId});
    }
}