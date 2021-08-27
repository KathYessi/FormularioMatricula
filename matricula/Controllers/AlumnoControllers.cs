using Microsoft.AspNetCore.Mvc;
using matricula.Models;


namespace matricula.Controllers
{
    public class AlumnoControllers:Controller
    {
      public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Alumno objregistrar)
        {
           
        }
        
    }
}