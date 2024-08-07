namespace EMS.Web.Controllers;

public class EmployeeController (IEmployeeService employeeService): Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var employees = await employeeService.GetAllEmployeesAsync();
        return View(employees);
    }
    [HttpGet("create")]
    public IActionResult Create()
    {
        var employeeViewModel = new EmployeeModel
        {
            Qualifications = [],
            Experiences = [],
            GovernmentDocuments =[] ,
            Certifications = [],
            PersonalDetails = new PersonalDetailsModel()
        };

        return View(employeeViewModel);
    }
    
    [HttpPost("create")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(EmployeeModel employeeModel)
    {
        if (!ModelState.IsValid)
        {
            return View(employeeModel);
        }
        await employeeService.AddEmployeeAsync(employeeModel);
        return RedirectToAction(nameof(Index));
    }
    
    
    // GET: Employee/Edit/5
    public async Task<IActionResult> Edit(Guid id)
    {
        var employee = await employeeService.GetEmployeeByIdAsync(id);
        if (employee == null)
        {
            return NotFound();
        }
        return View(employee);
    }
    
    // POST: Employee/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, EmployeeModel employee)
    {
        if (id != employee.EmployeeId)
        {
            return BadRequest();
        }

        if (ModelState.IsValid)
        {
            await employeeService.UpdateEmployeeAsync(employee);
            return RedirectToAction(nameof(Index));
        }
        return View(employee);
    }
    // GET: Employee/Details/5
    public async Task<IActionResult> Details(Guid id)
    {
        var employee = await employeeService.GetEmployeeByIdAsync(id);
        if (employee == null)
        {
            return NotFound();
        }
        return View(employee);
    }
    // GET: Employee/Delete/5
    public async Task<IActionResult> Delete(Guid id,Guid employeeId)
    {
        var employee = await employeeService.GetEmployeeByIdAsync(id);
        if (employee == null)
        {
            return NotFound();
        }

        ViewBag.EmployeeId = employeeId;
        return View(employee);
    }

    // POST: Employee/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await employeeService.DeleteEmployeeAsync(id);
        return RedirectToAction(nameof(Index));
    }
    

    

}