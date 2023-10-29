using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{ 

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class OrnekController1 : Controller
    {
        public IActionResult Index()
        {
            var productList = new List<Product>()
            {
                new(){Id=1, Name = "Kalem"},
                new(){Id=2, Name = "Defter"},
                new(){Id=3, Name = "Silgi"},
            };

            //ViewData ve ViewBag controller ve view arasındaki verilere erişmek için kullanılır
            //TempData bir requestten diğer bir requeste veri yollamak için kullanılır, diğerlerinden ayrılan özelliği .net sessionu kullanmasıdır
            //ViewBag.name = "ahmet";

            //TempData["surname"] = "yıldız"; //Temp data ile bir sayfadan başka bir sayfaya data taşınabilir
            //ViewBag.name = "Asp.Net Core";

            //ViewData["age"] = 30;

            //ViewData["names"]= new List<string>() { "ahmet", "mehmet", "hasan"};

            //ViewBag.person = new { Id = 1, Name = "ahmet", Age = 23 };
            //ViewBag.name = new List<string>() { "ata", "berk", "yılmaz"};
            return View(productList);
        }

        public IActionResult Index2()
        {
            var surName = TempData["surname"];

            return View();
        }




        public IActionResult Index3() 
        { 
            return RedirectToAction("Index", "Ornek"); //ornek altındaki index sayfasına yönlendir //veritabanı kaydetme işlemi
            //return View();
        }

        public IActionResult ParametreView(int id) //action methotların alabileceği parametreleri int değerleri ile verebiliriz
        {

            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });
        }

        public IActionResult JsonResultParametre(int id) //action methodtan başka bir action methoda parametre taşıma
        {
            return Json(new { Id = id });

        }
        public IActionResult ContentResult()
        {
            return Content("Content Result"); //String ifade döndürmek istediğim zaman
        }

        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "kalem1", price = 100 }); //json değerleri döndürmek için kullanılır
        }

        public IActionResult EmptyResult() 
        {
            return new EmptyResult(); //Boş sayfa
        }

        }
    }

