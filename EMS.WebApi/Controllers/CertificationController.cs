using Microsoft.AspNetCore.Mvc;

namespace EMS.WebApi.Controllers;

public class CertificationController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}