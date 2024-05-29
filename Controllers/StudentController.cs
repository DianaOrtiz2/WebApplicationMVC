
namespace WebApplicationMVC.Controllers;
using WebApplicationMVC.Models;

using Microsoft.AspNetCore.Mvc;
public class StudentController : Controller
{
    public StudentController(){

    }
    public IActionResult StudentAdd(){
        return View();
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
    
}