using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

public class ExperiencesController(IExperienceService experienceService) : Controller
{
    // GET: Experiences/Create
    public IActionResult Create(Guid employeeId)
    {
        ViewBag.EmployeeId = employeeId;
        return PartialView("_CreateExperience");
    }

    // POST: Experiences/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ExperienceModel experience)
    {
        if (ModelState.IsValid)
        {
            await experienceService.AddExperienceAsync(experience.EmployeeId,experience);
            TempData["success"] = "Experience added successfully.";
            return RedirectToAction("Details", "Employee", new { id = experience.EmployeeId });
        }
        ViewBag.EmployeeId = experience.EmployeeId;
        TempData["error"] = "Failed to add experience.";
        return PartialView("_CreateExperience", experience);
    }

    // GET: Experiences/Edit/{id}
    public async Task<IActionResult> Edit(Guid id, Guid employeeId)
    {
        var experience = await experienceService.GetExperienceByIdAsync(id);
        if (experience == null)
        {
            TempData["error"] = "Experience not found.";
            return RedirectToAction("Error", "Home");
        }
        
        ViewBag.EmployeeId = employeeId;
        return PartialView("_EditExperience", experience);
    }

    // POST: Experiences/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(ExperienceModel experience)
    {
        if (ModelState.IsValid)
        {
            await experienceService.UpdateExperienceAsync(experience.ExperienceId, experience);
            TempData["success"] = "Experience updated successfully.";
            return RedirectToAction("Details", "Employee", new { id = experience.EmployeeId });
        }
        ViewBag.EmployeeId = experience.EmployeeId;
        return PartialView("_EditExperience", experience);
    }

    // GET: Experiences/Delete/{id}
    public async Task<IActionResult> Delete(Guid id, Guid employeeId)
    {
        var experience = await experienceService.GetExperienceByIdAsync(id);
        if (experience == null)
        {
            TempData["error"] = "Experience not found.";
            return RedirectToAction("Error", "Home");
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_DeleteExperience", experience);
    }

    // POST: Experiences/Delete
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(ExperienceModel experience)
    {
        await experienceService.DeleteExperienceAsync(experience.ExperienceId);
        TempData["success"] = "Experience deleted successfully.";
        return RedirectToAction("Details", "Employee", new { id = experience.EmployeeId });
    }
}