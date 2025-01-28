using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EjercicioRepaso.Models;
using EjercicioRepaso.Interfaz;

namespace EjercicioRepaso.Controllers;

public class HomeController : Controller

{
    private readonly IAlumno alumnos;
    public int posicionAlumno=0;
    public HomeController(IAlumno a)
    
    {
        this.alumnos = a;
    }


    public IActionResult Index()
    {
        List<Alumno> lista = alumnos.ObtenerTodosLosAlumnos();
        return View(lista);
    }

    public IActionResult CrearAlumno()
    {
        return View();
    }

    [HttpPost]

    public IActionResult CrearAlumno(Alumno aNuevo)
    {
        this.alumnos.addAlumno(aNuevo);
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int id)

    {
        posicionAlumno = id;
        Alumno a = this.alumnos.AlumnoId(posicionAlumno);
        return View(a);
    }
    [HttpPost]
    public IActionResult Editar(Alumno a)
    {
        if (this.alumnos.buscarporDNI(a) != null)
        {
            this.alumnos.buscarporDNI(a).Telefono = a.Telefono;
            
        }
      
        return RedirectToAction("Index");
    }

    public IActionResult Borrar(int id)
    {
        posicionAlumno = id;
        Alumno a = this.alumnos.AlumnoId(posicionAlumno);
        this.alumnos.borrarporDNI(a);
      

        return RedirectToAction("Index");
    }

}

