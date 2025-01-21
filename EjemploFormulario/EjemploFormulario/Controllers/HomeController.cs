using System.Diagnostics;
using EjemploFormulario.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemploFormulario.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Contact(ContactDatos c)
        {
            TempData["Nombre"]=c.nombre;
			TempData["Email"] = c.Email;
			TempData["Mensaje"] = c.Mensaje;
			return RedirectToAction("ShowData",c);
        }
        public IActionResult ShowData()
            
        {
            ContactDatos c = new ContactDatos()
            {
                nombre = TempData["Nombre"].ToString(),
                Email = TempData["Nombre"].ToString(),
                Mensaje = TempData["Nombre"].ToString()
            };
                return View(c);
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
}
