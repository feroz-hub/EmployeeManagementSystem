namespace EMS.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeSalaryController(IEmployeeSalaryService employeeSalaryService) : Controller
{
    [HttpGet("{employeeId}")]
    public async Task<IActionResult> GetEmployeeSalary(Guid employeeId)
    {
        var employeeSalary = await employeeSalaryService.GetEmployeeSalary(employeeId);
        return Ok(employeeSalary);
    }

    [HttpPost("CalculateSalary/{employeeId}")]
    public async Task<IActionResult> CalculateSalary(Guid employeeId)
    {
        await employeeSalaryService.CalculateAndStoreSalary(employeeId);
        return Ok();
    }
}