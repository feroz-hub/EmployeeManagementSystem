using EMS.Domain.Entities.EmployeeDetails;
using Microsoft.AspNetCore.Mvc;

namespace EMS.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PersonalDetailsController(IPersonalDetailsService personalDetailsService) : Controller
{
    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<PersonalDetails>>> GetPersonalDetails()
    // {
    //     var personalDetails = await personalDetailsService.G();
    //     return Ok(personalDetails);
    // }

    [HttpGet("{id}")]
    public async Task<ActionResult<PersonalDetails>> GetPersonalDetails(Guid id)
    {
        var personalDetails = await personalDetailsService.GetPersonalDetailsByEmployeeIdAsync(id);
        if (personalDetails == null) return NotFound();
        return Ok(personalDetails);
    }

    [HttpPost]
    public async Task<ActionResult<PersonalDetails>> AddPersonalDetails(PersonalDetailsModel personalDetails)
    {
         await personalDetailsService.AddPersonalDetailsAsync(personalDetails);
         return Ok();
         //return CreatedAtAction(nameof(GetPersonalDetails), new { id = newPersonalDetails.EmployeeId }, newPersonalDetails);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePersonalDetails(Guid id, PersonalDetails personalDetails)
    {
        if (id != personalDetails.EmployeeId) return BadRequest();
        await personalDetailsService.UpdatePersonalDetailsAsync(personalDetails);
        // if (updatedPersonalDetails == null) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePersonalDetails(Guid id)
    {
        var result = await personalDetailsService.DeletePersonalDetailsAsync(id);
        if (!result) return NotFound();
        return NoContent();
    }
}