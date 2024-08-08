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
        TempData["success"] = "Employee Has been Added Successfully";
        return RedirectToAction(nameof(Index));
    }
    
    
    // GET: Employee/Edit/5
    public async Task<IActionResult> Edit(Guid id)
    {
        var employee = await employeeService.GetEmployeeByIdAsync(id);
        if (employee == null)
        {
            TempData["error"] = "Employee not found.";
            return RedirectToAction("Error", "Home");
        }
        TempData["success"] = "Employee found successfully.";
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
            TempData["success"] = "Employee Has been Updated Successfully";

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
            TempData["error"] = "Employee not found.";
            return RedirectToAction("Error", "Home");
        }
        TempData["success"] = "Employee found successfully.";
        return View(employee);
    }
    // GET: Employee/Delete/5
    public async Task<IActionResult> Delete(Guid id,Guid employeeId)
    {
        var employee = await employeeService.GetEmployeeByIdAsync(id);
        if (employee == null)
        {
            TempData["error"] = "Employee not found.";
            return RedirectToAction("Error", "Home");
        }
        ViewBag.EmployeeId = employeeId;
        return PartialView("_DeleteEmployee", employee);
    }

    // POST: Employee/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await employeeService.DeleteEmployeeAsync(id);
        TempData["success"] = "Employee Has been Deleted Successfully";
        return RedirectToAction(nameof(Index));
    }
    

    

}