using Microsoft.AspNetCore.Mvc;

namespace Lekeplass_kart_Bergen.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // This is the default view
        return View();
    }
}
