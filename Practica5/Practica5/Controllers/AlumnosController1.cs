using Microsoft.AspNetCore.Mvc;
using Practica5.Interfaces;
using Practica5.Models;

namespace Practica5.Controllers
{
    public class AlumnosController1 : Controller
    {
        private readonly IAlumno data;
        private readonly ICiclo dataCiclo;
        public AlumnosController1(IAlumno r, ICiclo c)
        {
            this.data = r;
            this.dataCiclo = c;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
