using EjemploBBDDEF.Models;
using EjemploBBDDEF.Repository;
using EjemploBBDDEF.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploBBDDEF.Controllers
{
    public class CursosController : Controller
    {

        private readonly IRepositoryCursos dataCursos;
        private readonly IRepositoryAlumnos dataAlumnos;
        private readonly IRepositoryCiclos dataCiclos;

        public CursosController(IRepositoryCursos dataCursos,IRepositoryAlumnos dataAlumnos, IRepositoryCiclos dataCiclos)
        {
            this.dataCursos = dataCursos;
            this.dataAlumnos = dataAlumnos;
            this.dataCiclos = dataCiclos;
        }




        // GET: CursosController/Details/5
        public ActionResult Details(string siglas)
        {
            CicloDetailView ciclo = new CicloDetailView()
            {
                ciclo = this.dataCiclos.FindCiclo(siglas),
                Cursos = this.dataCursos.getCursosCiclo(siglas),
               
                Alumnos = this.dataAlumnos.getAlumnosCicloByCurso(siglas)
            };          
            return View(ciclo);
        }

        // GET: CursosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CursosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CursosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CursosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
