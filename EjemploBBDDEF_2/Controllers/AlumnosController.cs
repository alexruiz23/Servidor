using EjemploBBDDEF.Models;
using EjemploBBDDEF.Repository;
using EjemploBBDDEF.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploBBDDEF.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly IRepositoryAlumnos data;
        private readonly IRepositoryCiclos dataCiclo;
        public AlumnosController(IRepositoryAlumnos r,IRepositoryCiclos c)
        {
            this.data = r;
            this.dataCiclo = c;
        }


        // GET: AlumnosController
        public ActionResult Index(string siglas)
        {
            List<Alumno> l = this.data.getAlumnosCiclo(siglas);
            Ciclo cl=this.dataCiclo.FindCiclo(siglas);
            AlumnosCicloView a = new AlumnosCicloView
            {
                lista = l,
                ciclo = cl.Nombre
            };
            return View(a);
        }

        // GET: AlumnosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlumnosController/Create
        public ActionResult Create(string siglas)
        {
            Alumno a = new Alumno();
            a.CicloAlumno = siglas;
            return View(a);
        }

        // POST: AlumnosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alumno a)
        {
           if (!ModelState.IsValid)
                return View(a);
           if (data.findAlumno(a.DNI) != null)
            {
                ModelState.AddModelError(nameof(a.DNI), $"El DNI {a.DNI} ya está dado de alta");
                return View();

            }
           this.data.addAlumnos(a);
           return RedirectToAction("Index","Home");
            
            
        }

        // GET: AlumnosController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: AlumnosController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: AlumnosController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: AlumnosController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}

