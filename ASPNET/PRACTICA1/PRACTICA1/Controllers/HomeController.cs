using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRACTICA1.Models;

namespace PRACTICA1.Controllers
{
    public class HomeController : Controller
    {
     


    

        public IActionResult Proyectos()
        {
            L_Proyectos listaP = new L_Proyectos()
            {
                misProyectos = new List<Proyectos> {

                new Proyectos
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/amazon.png"
            },
                new Proyectos
            {
                Titulo = "New York Times",
                Descripcion = "Página de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = "/imagenes/nyt.png"
            },
                new Proyectos
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = "/imagenes/reddit.png"
            },
                new Proyectos
            {
                Titulo = "Steam",
                Descripcion = "Tienda en línea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = "/imagenes/steam.png"
            },
}
            };
            Portfolio port = new Portfolio
            {
                Persona = new Persona
                {
                    edad = 22,
                    nombre = "Alejandro",
                    perfil = ""
                },
                Proyectos = listaP
            };

            return View("Proyectos",port);
        } 



    }
}
