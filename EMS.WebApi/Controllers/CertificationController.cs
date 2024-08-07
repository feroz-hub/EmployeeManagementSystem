namespace EMS.WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CertificationController(ICertificationService certificationService,IMapper mapper) : Controller
{
   // GET: api/Certification/employee/{employeeId}
    [HttpGet("employee/{employeeId}")]
    public async Task<IActionResult> GetCertificationsByEmployeeId(Guid employeeId)
    {
        var certifications = await certificationService.GetCertificationsByEmployeeIdAsync(employeeId);
        return Ok(certifications);
    }

    // GET: api/Certification/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCertificationById(Guid id)
    {
        var certification = await certificationService.GetCertificationByIdAsync(id);
        if (certification == null)
        {
            return NotFound();
        }
        return Ok(certification);
    }

    // POST: api/Certification
    [HttpPost]
    public async Task<IActionResult> AddCertification(Guid employeeId, [FromBody] CertificationModel certificationModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await certificationService.AddCertificationAsync(employeeId, certificationModel);
        return Ok();
    }

    // PUT: api/Certification/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCertification(Guid id, [FromBody] CertificationModel certificationModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            await certificationService.UpdateCertificationAsync(id, certificationModel);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }

    // DELETE: api/Certification/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCertification(Guid id)
    {
        try
        {
            await certificationService.DeleteCertificationAsync(id);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }
}