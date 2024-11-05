using System.Diagnostics;
using Lekeplass_kart_Bergen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lekeplass_kart_Bergen.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
