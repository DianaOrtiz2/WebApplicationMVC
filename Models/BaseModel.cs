using System;
namespace WebApplicationMVC.Models
{
    public class BaseModel
    {
        public BaseModel(){

        }
        public Guid id { get; set; }
         public DateTime FechaCreacio { get; set; }
        
    }
}