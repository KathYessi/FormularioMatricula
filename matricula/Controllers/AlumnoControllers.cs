
using matricula.Models;
using Microsoft.AspNetCore.Mvc;


namespace matricula.Controllers
{
    public class AlumnoControllers:Controller
    {
      public IActionResult Index()
        {
            return View();
        }

        
    }
}