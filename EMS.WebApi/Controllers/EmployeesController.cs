namespace EMS.WebApi.Controllers;
[Route("api/employee")]
[ApiController]
public class EmployeesController(IEmployeeService employeeService ,IMapper mapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetEmployees()
    {
        var employees = await employeeService.GetAllEmployeesAsync();
       // var employeeModel = mapper.Map<EmployeeModel>(employees);
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
    public async Task<IActionResult> AddEmployee(EmployeeModel employeeModel)
    {
        await employeeService.AddEmployeeAsync(employeeModel);
        return Ok();
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(Guid id, EmployeeModel employee)
    {
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