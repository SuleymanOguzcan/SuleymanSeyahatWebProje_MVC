using Microsoft.AspNetCore.Mvc;
using SuleymanSeyahat.Models.Siniflar;

namespace SuleymanSeyahat.Controllers
{
	public class AboutController : Controller
	{
		DataContext db;//DI
		public AboutController(DataContext _db)
		{
			db = _db;
		}
		public IActionResult Index()
		{
			var degerler = db.Hakkimizdas.ToList();
			return View(degerler);
		}
	}
}
