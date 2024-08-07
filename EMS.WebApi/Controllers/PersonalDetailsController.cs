using EMS.Domain.Entities.EmployeeDetails;

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
    public async Task<IActionResult> GetPersonalDetails(Guid id)
    {
        var personalDetails = await personalDetailsService.GetPersonalDetailsByEmployeeIdAsync(id);
        if (personalDetails == null) return NotFound();
        return Ok(personalDetails);
    }

    [HttpPost(template:"{id}")]
    public async Task<IActionResult> AddPersonalDetails(Guid id,PersonalDetailsModel personalDetails)
    {
         await personalDetailsService.AddPersonalDetailsAsync(id,personalDetails);
         return Ok();
         //return CreatedAtAction(nameof(GetPersonalDetails), new { id = newPersonalDetails.EmployeeId }, newPersonalDetails);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePersonalDetails(Guid id, PersonalDetailsModel personalDetails)
    {
        await personalDetailsService.UpdatePersonalDetailsAsync(id,personalDetails);
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