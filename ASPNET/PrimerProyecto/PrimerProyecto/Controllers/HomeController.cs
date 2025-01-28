using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult TeSaludo()
        {
            return View();
        }
        public IActionResult MeDespido()
        {
            return View();
        }
        public IActionResult Ati()
        {
            string nombre = "alex";
            int edad = 22;
            string mensaje = "";
            if (edad < 50)
                mensaje = "Que joven eres";
            else
                mensaje="WOWO QUE VIEJO BOY";
            ViewData["name"]=nombre;
            ViewData["age"] = edad;
            ViewData["msg"] = mensaje;

            return View();
        }





    }
}
