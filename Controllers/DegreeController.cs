using System.Runtime.CompilerServices;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers;

public class DegreeController : Controller
{
    public DegreeController(){

    }
    public IActionResult DegreeAdd(){
        return View();
    }
    public IActionResult DegreeSave(){
        return View();
    }

     public IActionResult DegreeList()
    {
        DegreeModel carrera = new DegreeModel();
        carrera.Nombre = "Licenciatura en Administracion De Tecnologias";

        DegreeModel carrera2 = new DegreeModel();
        carrera2.Nombre = "Ingenieria en Sistemas";

        DegreeModel carrera3 = new DegreeModel();
        carrera3.Nombre = "Licenciatura en Administracion de Empresas";
        
        List<DegreeModel> List = new List<DegreeModel>();
        List.Add(carrera);
        List.Add(carrera2);
        List.Add(carrera3);

        return View(List);
        
        
    }
    
}
