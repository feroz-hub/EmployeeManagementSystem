using System.Diagnostics;
using EMS.Web.Models;

namespace EMS.Web.Controllers;

public class HomeController(IEmployeeService employeeService,ILeaveService leaveService,IQualificationService qualificationService,ICertificationService certificationService,IEmployeeSalaryService employeeSalaryService) : Controller
{
    
    public async Task<IActionResult> Index()
    {
        var dashBoardData = new DashBoardViewModel()
        {
            TotalEmployees = await employeeService.GetTotalEmployeesAsync(),
            EmployeesByDepartment = await employeeService.GetEmployeesByDepartmentAsync(),
            EmployeesByType = await employeeService.GetEmployeesByTypeAsync(),
            TotalLeavesApplied = await leaveService.GetTotalLeaveAppliedAsync(),
            PendingLeaveRequests = await leaveService.GetPendingLeaveRequest(),
            AverageEmployeeSalary = await employeeSalaryService.AverageEmployeeSalaryAsync(),
            RecentEmployees = await employeeService.RecentEmployeesAsync(),
            UpcomingCertificationsExpiry = await certificationService.GetUpcomingCertificateExpiry(),
            RecentLeaveRequests = await leaveService.GetRecentLeaveRequestAsync()

        };
        
        return View(dashBoardData);
    }
    public IActionResult Error()
    {
        return View();
    }


  
}
