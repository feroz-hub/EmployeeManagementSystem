namespace EMS.WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ReportController(IReportService reportService,IOptions<ReportSettings> reportSettings) : Controller
{
    // GET: api/Report
    [HttpGet]
    public async Task<IActionResult> GetDepartmentReports()
    {
        var reports = await reportService.GetDepartmentReportsAsync();
        return Ok(reports);
    }

    // GET: api/Report/Generate
    [HttpGet("Generate")]
    public async Task<IActionResult> GenerateReport()
    {
        var reports = await reportService.GetDepartmentReportsAsync();
        reportService.GenerateDepartmentReport(reports, reportSettings.Value.FilePath);
        return Ok(new { Message = "Report generated successfully.", FilePath = reportSettings.Value.FilePath });
    }
}