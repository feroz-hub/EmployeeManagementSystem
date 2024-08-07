using EMS.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

public class EmployeeController (IEmployeeService employeeService): Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var employees = await employeeService.GetAllEmployeesAsync();
        return View(employees);
    }
}