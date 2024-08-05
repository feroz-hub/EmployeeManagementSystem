namespace EMS.WebApi.Controllers;
[Route("api/employee")]
[ApiController]
public class EmployeesController(IEmployeeService employeeService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetEmployees()
    {
        var employees = await employeeService.GetAllEmployeesAsync();
        return Ok(employees);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployee(Guid id)
    {
        var employee = await employeeService.GetEmployeeByIdAsync(id);
        if (employee == null)
            return NotFound();
        return Ok(employee);
    }

    [HttpPost]
    public async Task<IActionResult> AddEmployee(Employee employee)
    {
        await employeeService.AddEmployeeAsync(employee);
        return CreatedAtAction(nameof(GetEmployee), new { id = employee.EmployeeId }, employee);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(Guid id, Employee employee)
    {
        if (id != employee.EmployeeId)
            return BadRequest();
        await employeeService.UpdateEmployeeAsync(employee);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(Guid id)
    {
        await employeeService.DeleteEmployeeAsync(id);
        return NoContent();
    }
}