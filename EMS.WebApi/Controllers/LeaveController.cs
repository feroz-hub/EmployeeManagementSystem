using Microsoft.AspNetCore.Mvc;

namespace EMS.WebApi.Controllers;

public class LeaveController (ILeaveService leaveService ): Controller
{
    // GET: api/Leave/employee/{employeeId}
    [HttpGet("employee/{employeeId}")]
    public async Task<ActionResult<IEnumerable<LeaveModel>>> GetLeavesByEmployeeId(Guid employeeId)
    {
        var leaves = await leaveService.GetLeavesByEmployeeIdAsync(employeeId);
        return Ok(leaves);
    }

    // GET: api/Leave/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<LeaveModel>> GetLeaveById(Guid id)
    {
        var leave = await leaveService.GetLeaveByIdAsync(id);
        if (leave == null)
        {
            return NotFound();
        }
        return Ok(leave);
    }

    // POST: api/Leave
    [HttpPost]
    public async Task<ActionResult> ApplyLeave(Guid employeeId, [FromBody] LeaveModel leaveModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await leaveService.AddLeaveAsync(employeeId, leaveModel);
        return Ok();
    }

    // PUT: api/Leave/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateLeave(Guid id, [FromBody] LeaveModel leaveModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            await leaveService.UpdateLeaveAsync(id, leaveModel);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }

    // DELETE: api/Leave/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> CancelLeave(Guid id)
    {
        try
        {
            await leaveService.DeleteLeaveAsync(id);
        }
        catch (Exception ex)
        {
            return NotFound(new { Message = ex.Message });
        }

        return NoContent();
    }
}