using System.Diagnostics;
using EjemploControllerForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemploControllerForm.Controllers
{
	public class HomeController : Controller
	{
	
		public IActionResult getDatos(string sexo, string[]aficiones,string ciclo) {
			return View("getDatos");
		}

		public IActionResult Index()
		{
			return View();
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
