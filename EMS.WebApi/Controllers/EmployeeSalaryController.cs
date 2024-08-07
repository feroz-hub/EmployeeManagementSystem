namespace EMS.WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
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
    [HttpPost]
    public async Task<IActionResult> CalculateSalaryForAllEmployee()
    {
        await employeeSalaryService.CalculateAndStoreSalariesForAllEmployees();
        return Ok();
    }
}