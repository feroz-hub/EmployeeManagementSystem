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
    
    [HttpGet("GenerateExcel")]
    public async Task<IActionResult> GenerateExcelReport()
    {
        var reports = await reportService.GetDepartmentReportsAsync();
        reportService.GenerateDepartmentReport(reports, reportSettings.Value.FilePath);
        TempData["success"] = "Report generated successfully.";
        ViewBag.Message = "Report generated successfully.";
        ViewBag.FilePath = reportSettings.Value.FilePath;
        return RedirectToAction("Index");
    }
    
    [HttpGet("GeneratePdf")]
    public async Task<IActionResult> GeneratePdfReport()
    {
        var reports = await reportService.GetDepartmentReportsAsync();
        using var stream = new MemoryStream();
        reportService.GenerateDepartmentReportPdf(reports,stream);
        stream.Position = 0;
        TempData["success"] = "Report generated successfully.";
        ViewBag.Message = "Report generated successfully.";
        return File(stream,"application/pdf","DepartmentReport.pdf");
    }
}