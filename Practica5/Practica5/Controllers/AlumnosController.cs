using Microsoft.AspNetCore.Mvc;
using Practica5.Interfaces;
using Practica5.Models;

namespace Practica5.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly IAlumno data;
        private readonly ICiclo dataCiclo;
        public AlumnosController(IAlumno r, ICiclo c)
        {
            this.data = r;
            this.dataCiclo = c;
        }
        public ActionResult Index(string siglas)
        {
            List<Alumno> l = this.data.getAlumnosCiclo(siglas);
            Ciclo cl = this.dataCiclo.FindCiclo(siglas);
            AlumnosCicloView a = new AlumnosCicloView
            {
                lista = l,
                CicloAlumno = cl.Nombre
            };
            return View(a);
        }
        public ActionResult Create(string siglas)
        {
            Alumno a = new Alumno();
            a.CicloAlumno = siglas;
            return View(a);
        }
    }
}
