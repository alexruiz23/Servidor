using Clases.Interfaces;
using Clases.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clases.Controllers
{
    public class Admin : Controller
    {
        private readonly ITallerS data;
        private readonly ICochesS data2;
        private readonly IMecanicoS data3;
        private readonly ILoginS data4;
        public Admin(ITallerS data, ICochesS data2, IMecanicoS data3, ILoginS data4)
        {
            this.data = data;
            this.data2 = data2;
            this.data3 = data3;
            this.data4 = data4;
        }

        public ActionResult Index()
        {

            Taller t = new()
            {
                nombre = this.data.GetTaller().nombre,
                direccion = this.data.GetTaller().direccion,
                telefono = this.data.GetTaller().telefono,
                coches = this.data2.getCoche(),
                mecanicos = this.data3.getMecanicos(),

            };
            return View(t);
        }

       

     

       
        
    }
}
