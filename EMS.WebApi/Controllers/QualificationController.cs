namespace EMS.WebApi.Controllers;

public class QualificationController (IQualificationService qualificationService,IMapper mapper): Controller
{
    
    // GET: api/Qualification/employee/{employeeId}
    [HttpGet("employee/{employeeId}")]
    public async Task<ActionResult<IEnumerable<QualificationModel>>> GetQualificationsByEmployeeId(Guid employeeId)
    {
        var qualifications = await qualificationService.GetQualificationsByEmployeeIdAsync(employeeId);
        return Ok(qualifications);
    }

    // GET: api/Qualification/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<QualificationModel>> GetQualificationById(Guid id)
    {
        var qualification = await qualificationService.GetQualificationByIdAsync(id);
        if (qualification == null)
        {
            return NotFound();
        }
        return Ok(qualification);
    }

    // POST: api/Qualification
    [HttpPost]
    public async Task<ActionResult> AddQualification(Guid employeeId, [FromBody] QualificationModel qualificationModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await qualificationService.AddQualificationAsync(employeeId, qualificationModel);
        return Ok(); 
    }

    // PUT: api/Qualification/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateQualification(Guid id, [FromBody] QualificationModel qualificationModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            await qualificationService.UpdateQualificationAsync(id, qualificationModel);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }

    // DELETE: api/Qualification/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteQualification(Guid id)
    {
        try
        {
            await qualificationService.DeleteQualificationAsync(id);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }
}