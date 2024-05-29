using System;
using System.Security;
namespace WebApplicationMVC.Models

public class EmptyModel : BaseModel
{
    Public class BaseModel
    {
        public BaseModel(){

        }
        
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }

    }
}