using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Interfaces;
using Peliculas.Models;
using Peliculas.Repository;
using IRepositorioPeliculas = Peliculas.Interfaces.IRepositorioPeliculas;

namespace Peliculas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioInfoPeliculas infoservice;
        private readonly IRepositorioPeliculas peliculaservices;
        private readonly IRepositorioGenero generoservices;



        public HomeController(IRepositorioInfoPeliculas InfoPeliculas,IRepositorioPeliculas Peliculaservices,IRepositorioGenero Genero)
        {
            this.infoservice = InfoPeliculas;
            this.peliculaservices= Peliculaservices;
            this.generoservices = Genero;
        }
        public IActionResult Index()
        {
           List <infoPeliculas> i = this.infoservice.GetInfo();
            List<Pelicula> p = this.peliculaservices.GetP();
            List<Genero> g = this.generoservices.GetG();

            TodoView t = new TodoView();
            t.infoPeliculas = i;
            t.Peliculas = p;
            t.Generos = g;

            return View(t);
        }

        public IActionResult Details() {

            return View();


        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
