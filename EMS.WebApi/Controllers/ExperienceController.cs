using EMS.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS.WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ExperienceController(IExperienceService experienceService) : Controller
{
   // GET: api/Experience/employee/{employeeId}
    [HttpGet("employee/{employeeId}")]
    public async Task<ActionResult<IEnumerable<ExperienceModel>>> GetExperiencesByEmployeeId(Guid employeeId)
    {
        var experiences = await experienceService.GetExperiencesByEmployeeIdAsync(employeeId);
        return Ok(experiences);
    }

    // GET: api/Experience/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<ExperienceModel>> GetExperienceById(Guid id)
    {
        var experience = await experienceService.GetExperienceByIdAsync(id);
        if (experience == null)
        {
            return NotFound();
        }
        return Ok(experience);
    }

    // POST: api/Experience
    [HttpPost]
    public async Task<ActionResult> AddExperience(Guid employeeId, [FromBody] ExperienceModel experienceModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await experienceService.AddExperienceAsync(employeeId, experienceModel);
        return Ok();

    }

    // PUT: api/Experience/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateExperience(Guid id, [FromBody] ExperienceModel experienceModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            await experienceService.UpdateExperienceAsync(id, experienceModel);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }

    // DELETE: api/Experience/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteExperience(Guid id)
    {
        try
        {
            await experienceService.DeleteExperienceAsync(id);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }
}