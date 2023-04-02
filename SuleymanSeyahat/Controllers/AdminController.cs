using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using SuleymanSeyahat.Models.Siniflar;

namespace SuleymanSeyahat.Controllers
{
    public class AdminController : Controller
    {
        DataContext db;//DI
        public AdminController(DataContext _db)
        {
            db = _db;
        }

        [Authorize]  //bu kısım eklenince url den adminin index ine gidemiyoruz.. bunun konfigürasyonuda program.cs den yapıldı.
        public IActionResult Index()
        {
            var degerler = db.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniBlog()
        {
            
            return View();  //sayfa yüklenirken boş döndür 
        }

        [HttpPost]
        public IActionResult YeniBlog(Blog p)
        {
            db.Blogs.Add(p);
            db.SaveChanges();
            return View();  //post yapınca yani içerikle beraber döndür
        }


    }
}
