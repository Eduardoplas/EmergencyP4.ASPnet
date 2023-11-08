using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Emergency.Models;
using Emergency;

namespace Emergency.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    Emergencyp4Context emergencyp4Context = new Emergencyp4Context();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    [HttpPost]
    public IActionResult Registrar(Usuario usuario)
    {
        emergencyp4Context.Add(usuario);
        emergencyp4Context.SaveChanges();
        Response.Redirect("/home/Index");
        return View();
    }
   

    [HttpPost]
    public IActionResult iniciar_sesion(IFormCollection form)
    {
        var correo = form["correo"];
        var password = form["password"];

        if (correo == "yo@yo.com" & password == "123") Response.Redirect("/home/sesion_doctor");
        ViewBag.mensaje = "Correo o Password Incorrecto";
        return View();
    }
    public IActionResult iniciar_sesion()
    {
        
        return View();
    }


    public IActionResult Borrar (int id)
    {
        var usuarioBorrar = emergencyp4Context.Usuarios.Find(id);
        emergencyp4Context.Usuarios.Remove(usuarioBorrar);
        emergencyp4Context.SaveChanges();
        return RedirectToAction("sesion_doctor");
    }

    public IActionResult Editar(int id)
    {
        var usuario = emergencyp4Context.Usuarios.Find(id);
        return View(usuario);
    }
    [HttpPost]
    public IActionResult Editar (Usuario usuario)
    {
       
        emergencyp4Context.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        emergencyp4Context.SaveChanges();

        ViewBag.Mensaje = "Se actualizo el usuario";
        return RedirectToAction("sesion_doctor");
    }


    [HttpGet]
    public IActionResult sesion_doctor(string textoBuscar)
    {
        var usuarios = new List<Usuario>();
        if (textoBuscar != "" && textoBuscar != null)
        {
         usuarios = emergencyp4Context.Usuarios.Where(a => (a.Nombre + " " + a.Paterno + " " + a.Materno).Contains(textoBuscar)).ToList();
        }
        else
        {
            usuarios = emergencyp4Context.Usuarios.ToList();
        }
        ViewBag.textoBuscar = textoBuscar;
        return View(usuarios);
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

    public IActionResult DetalleUsuario(int? id)
    {
        if (id == null) return NotFound();
        Usuario usuario = emergencyp4Context.Usuarios.Find(id);
        if (usuario == null) return NotFound();
        return View(usuario);
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

