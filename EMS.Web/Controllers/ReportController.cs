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
    
    [HttpGet]
    public async Task<IActionResult> GeneratePdfReport()
    {
        var departmentReports = await reportService.GetDepartmentReportsAsync();

        // Generate the PDF in-memory
         var pdfStream = new MemoryStream();
        reportService.GenerateDepartmentReportPdf(departmentReports, pdfStream);
        pdfStream.Position = 0;

        var fileName = $"Report_{DateTime.Now:yyyy-MM-dd}.pdf";

        // Return the PDF as a FileResult
        return File(pdfStream, "application/pdf", fileName);
    }
}