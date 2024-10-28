using MacDonalds.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MacDonalds.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            return View(); // Com a view vazia vai buscar uma view com nome da Action ("Index")
        }
        public IActionResult Demo()
        {
            return View(); // Com a view vazia vai buscar uma view com nome da Action ("Demo")
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
