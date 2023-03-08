using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Uygulama1.Models;

namespace Uygulama1.Controllers
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
            DataModel model1 = new DataModel(
                "https://www.firstbenefits.org/wp-content/uploads/2017/10/placeholder-1024x1024.png",
                "Deniz Manzarası",
                "Lorem upsom Lorem upsomLorem upsomLorem upsomLorem upsomLorem upsom"
                );
            DataModel model2 = new DataModel(
                "https://www.firstbenefits.org/wp-content/uploads/2017/10/placeholder-1024x1024.png",
                "Göl Manzarası",
                "Lorem upsom Lormfdzşlmfbvmöfbövcxövcxöcvx"
                );
            DataModel model3 = new DataModel(
                "https://www.firstbenefits.org/wp-content/uploads/2017/10/placeholder-1024x1024.png",
                "Dağ Manzarası",
                "Lorem upsom Lcmdcxvbcxrkewjrtıorhgfdnvxczçvmds"
                );
            DataModel model4 = new DataModel(
                "https://www.firstbenefits.org/wp-content/uploads/2017/10/placeholder-1024x1024.png",
                "Şehir Manzarası",
                "Lorem upsom Lcmdcxvbcxrkewjrtıorhgfdnvxczçvmds"
                );
            var List = new List<DataModel>();

            List.Add(model1);
            List.Add(model2);
            List.Add(model3);
            List.Add(model4);

            return View(List);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Liste()
        {
            OgrenciModel ogr1 = new OgrenciModel(125, "Fatih", "Atamtürk", "AMP/9A");
            OgrenciModel ogr2 = new OgrenciModel(895, "ALi", "Kılıç", "AMP/10A");
            OgrenciModel ogr3 = new OgrenciModel(556, "Osman", "Güney", "AMP/11A");
            OgrenciModel ogr4 = new OgrenciModel(1024, "Sarp", "Demir", "AMP/12A");
             var ogrList = new List<OgrenciModel>();

            ogrList.Add(ogr1);
            ogrList.Add(ogr2);  
            ogrList.Add(ogr3);  
            ogrList.Add(ogr4);

            return View(ogrList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}