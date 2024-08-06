using EMS.Domain.Report;
using Microsoft.AspNetCore.Mvc;

namespace EMS.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReportController(IReportService reportService) : Controller
{
    // GET: api/Report
    [HttpGet]
    public async Task<ActionResult<List<DepartmentReport>>> GetDepartmentReports()
    {
        var reports = await reportService.GetDepartmentReportsAsync();
        return Ok(reports);
    }

    // GET: api/Report/Generate
    [HttpGet("Generate")]
    public async Task<IActionResult> GenerateReport(string filePath)
    {
        var reports = await reportService.GetDepartmentReportsAsync();
        reportService.GenerateDepartmentReport(reports, filePath);
        return Ok(new { Message = "Report generated successfully.", FilePath = filePath });
    }
}