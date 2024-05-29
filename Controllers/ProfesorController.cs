namespace WebApplicationMVC.Controllers;
using WebApplicationMVC.Models;

using Microsoft.AspNetCore.Mvc;
public class ProfesorController : Controller
{
    public ProfesorController(){

    }
    public IActionResult ProfesorAdd(){
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
    
}