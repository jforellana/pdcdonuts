using donuts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace donuts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
