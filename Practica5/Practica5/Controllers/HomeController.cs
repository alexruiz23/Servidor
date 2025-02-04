using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica5.Interfaces;
using Practica5.Models;

namespace Practica5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICiclo cicloservice;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ICiclo ciclo)
        {
            this.cicloservice = ciclo;
        }

        public IActionResult Index()
        {
            List<Ciclo> l = this.cicloservice.GetCiclos();
            return View(l);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details(string siglas)
        {
            Ciclo c = this.cicloservice.FindCiclo(siglas);
            return View(c);
        }

    }
}
