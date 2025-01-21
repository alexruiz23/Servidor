using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ALEXPRUEBA.Models;
using ALEXPRUEBA.Interfaces;

namespace ALEXPRUEBA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IServicioUsuarios Usuario;

    public HomeController(IServicioUsuarios Usuario)
    {
        this.Usuario = Usuario;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Registro()

    {
        
        return View();

    }

    public IActionResult Login(string nick,string contra)
    {
        var usu = this.Usuario.isUsuario(nick, contra);
        List<Alumno> Lista_alu = new List<Alumno>();



        if (usu != null)
            {
                if (usu is Alumno alumno)

                {
               
        
                    return RedirectToAction("AlumnoInd",alumno);
                }
                if(usu is Profesor p)
                {
                    Lista_alu = this.Usuario.getAlumnos();
                
                    return View("Alumno",Lista_alu);
                }
            

        }

        return RedirectToAction("Index");
    }
    public IActionResult Alumno(List<Alumno> alumnos)
    {
        return View(alumnos);
    }

    public IActionResult AlumnoInd(Alumno u)
    {
        return View(u);
    }

    public IActionResult GetRegistro(Alumno u)

    {
        this.Usuario.AñadirAlumno(u);
        return RedirectToAction("Index");
    }



}



