using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

public class EmployeeSalaryController(IEmployeeSalaryService employeeSalaryService) : Controller
{
    // GET: EmployeeSalary/CalculateAll
    public async Task<IActionResult> CalculateAll()
    {
        await employeeSalaryService.CalculateAndStoreSalariesForAllEmployees();
        return RedirectToAction("Index","Employee"); // Assuming there's an index view
    }
}