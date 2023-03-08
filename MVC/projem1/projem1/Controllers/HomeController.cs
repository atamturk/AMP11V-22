using Microsoft.AspNetCore.Mvc;
using projem1.Models;
using System.Diagnostics;

namespace projem1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = "Fatih";
            ogr.Sehir = "Kocaeli";
            return View(ogr);
        }

        public IActionResult Privacy()
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