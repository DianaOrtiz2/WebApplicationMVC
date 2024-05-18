using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers;

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
    public IActionResult ProfesoresList()
    {
        var profesor = new ProfesorModel
        {
            Nombre = "David",
            Materia = "Calculo Integral",
            Edad = 32,
            Email = "davidmendez@gmail.com",
            Sexo = "Hombre"
            
        };
        return View(profesor);
    }
    public IActionResult StudentList()
    {
        var student = new StudentModel
        {
            Nombre = "Diana",
            Matricula = 44776,
            Edad = 24,
            Carrera = "Ingeniería en Tecnologías de la Información / Software",
            Sexo = "Mujer"
            
        };
        return View(student);
    }
    public IActionResult DegreeList()
    {
        var degree = new DegreeModel
        {
            
            Carrera = "Ingeniería en Tecnologías de la Información / Software",
            Tetra = 9
            
        };
        return View(degree);
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
