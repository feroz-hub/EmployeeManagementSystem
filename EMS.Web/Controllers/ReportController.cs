using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EMS.Web.Controllers;

public class ReportController (IReportService reportService, IOptions<ReportSettings> reportSettings): Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var reports = await reportService.GetDepartmentReportsAsync();
        return View(reports);
    }
    
    [HttpGet("Generate")]
    public async Task<IActionResult> GenerateReport()
    {
        var reports = await reportService.GetDepartmentReportsAsync();
        reportService.GenerateDepartmentReport(reports, reportSettings.Value.FilePath);
        ViewBag.Message = "Report generated successfully.";
        ViewBag.FilePath = reportSettings.Value.FilePath;
        return RedirectToAction("Index");
    }
}