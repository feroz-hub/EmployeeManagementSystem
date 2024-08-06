using Microsoft.AspNetCore.Mvc;

namespace EMS.WebApi.Controllers;

public class GovernmentDocumentController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}