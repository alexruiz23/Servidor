using Microsoft.AspNetCore.Mvc;
using Practica5.Interfaces;
using Practica5.Models;
namespace Practica5.Controllers
{
    public class CursosController : Controller


    {
        private readonly ICurso dataCursos;
        private readonly IAlumno dataAlumnos;
        private readonly ICiclo dataCiclos;

        public CursosController(ICurso dataCursos, IAlumno dataAlumnos, ICiclo dataCiclos)
        {
            this.dataCursos = dataCursos;
            this.dataAlumnos = dataAlumnos;
            this.dataCiclos = dataCiclos;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
