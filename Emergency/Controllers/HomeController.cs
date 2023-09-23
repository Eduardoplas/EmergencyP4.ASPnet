using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Emergency.Models;

namespace Emergency.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public string StringHola()
    {
        return "hola";
    }

    public IActionResult Mas()
    {
        return View();
    }

    public IActionResult Ansiedad()
    {
        return View();
    }
    public IActionResult Registrar()
    {
        return View();
    }
    public IActionResult iniciar_sesion()
    {
        return View();
    }
    public IActionResult sesion_doctor()
    {
        return View();
    }
    public IActionResult Diabetes()
    {
        return View();
    }
    public IActionResult Alergias()
    {
        return View();
    }
    public IActionResult Depresion()
    {
        return View();
    }
    public IActionResult Colicos()
    {
        return View();
    }
    public IActionResult Estres()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

