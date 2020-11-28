using System;
using Microsoft.AspNetCore.Mvc;
namespace dotnet_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            
            string mesaj = saat>12?"İyi Günler":"Günaydın";

            ViewBag.Gretting = mesaj;
            ViewBag.UserName = "Osman";
            ViewBag.Mal = "deneme";

            return View();
        }
        public IActionResult About(){
            return View();
        }
        public IActionResult Contact(){
            return View("MyContact");
        }
    }
}