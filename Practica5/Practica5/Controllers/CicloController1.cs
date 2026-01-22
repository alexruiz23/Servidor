using Practica5.Models;
using Microsoft.AspNetCore.Mvc;
using Practica5.Interfaces;

namespace Practica5.Controllers
{
    public class CicloController1 : Controller
    {
        private readonly ICiclo dataCiclo;
        public CicloController1(ICiclo c)
        {
            
            this.dataCiclo = c;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
