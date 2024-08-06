namespace EMS.WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class GovernmentDocumentController (IGovernmentDocumentService governmentDocumentService,IMapper mapper): Controller
{
  // GET: api/GovernmentDocument/employee/{employeeId}
    [HttpGet("employee/{employeeId}")]
    public async Task<ActionResult<IEnumerable<GovernmentDocumentModel>>> GetDocumentsByEmployeeId(Guid employeeId)
    {
        var documents = await governmentDocumentService.GetGovernmentDocumentsByEmployeeIdAsync(employeeId);
        var documentModel = mapper.Map<IEnumerable<GovernmentDocumentModel>>(documents);
        return Ok(documentModel);
    }

    // GET: api/GovernmentDocument/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<GovernmentDocumentModel>> GetDocumentById(Guid id)
    {
        var document = await governmentDocumentService.GetGovernmentDocumentByIdAsync(id);
        if (document == null)
        {
            return NotFound();
        }
        return Ok(document);
    }

    // POST: api/GovernmentDocument
    [HttpPost]
    public async Task<ActionResult> AddDocument(Guid employeeId, [FromBody] GovernmentDocumentModel documentModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await governmentDocumentService.AddGovernmentDocumentAsync(employeeId, documentModel);
        return Ok();
    }

    // PUT: api/GovernmentDocument/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateDocument(Guid id, [FromBody] GovernmentDocumentModel documentModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            await governmentDocumentService.UpdateGovernmentDocumentAsync(id, documentModel);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }

    // DELETE: api/GovernmentDocument/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDocument(Guid id)
    {
        try
        {
            await governmentDocumentService.DeleteGovernmentDocumentAsync(id);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }
}