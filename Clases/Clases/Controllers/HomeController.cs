using System.Diagnostics;
using Clases.Interfaces;
using Clases.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clases.Controllers
{
	public class HomeController : Controller
	{
		private readonly ITallerS data;
		private readonly ICochesS data2;
        private readonly IMecanicoS data3;
		private readonly ILoginS data4;
        public HomeController(ITallerS data,ICochesS data2,IMecanicoS data3,ILoginS data4) {
			this.data = data;
			this.data2 = data2; 
			this.data3 = data3;
			this.data4=data4 ;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Login(LoginViewModel l)
		{
			if (l.usuario == "admin" && l.password == "admin")
				return RedirectToAction("Index", "Admin");
            else
				if (this.data3.isLogin(l))
					return RedirectToAction("Index", "MecanicosV");
            else
                if (this.data3.isLoginDueños(l))
                return RedirectToAction("Index", "MecanicosV");




        }
        public IActionResult Registrarse()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
