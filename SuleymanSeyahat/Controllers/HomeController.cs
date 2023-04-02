

using Microsoft.AspNetCore.Mvc;
using SuleymanSeyahat.Models;
using SuleymanSeyahat.Models.Siniflar;
using System.Diagnostics;

namespace SuleymanSeyahat.Controllers
{
    public class HomeController : Controller
    {
		DataContext db;
		public HomeController(DataContext _db)
		{
			db = _db;
		}

		
		public IActionResult Index()
		{
			var degerler = db.Blogs.ToList();
			return View(degerler);
		}

		public PartialViewResult Partial1()  //home sayfasındaki nesneleri html den kesip parçalı yapmak için bunu oluşturdum.. partial view diye view i var ve layout kullanmıyor zaten seçtim add view derken partial view oluştur diye
		{
			var degerler =  db.Blogs.OrderByDescending(x => x.ID).ToList();
			return PartialView();
		}

	}
}