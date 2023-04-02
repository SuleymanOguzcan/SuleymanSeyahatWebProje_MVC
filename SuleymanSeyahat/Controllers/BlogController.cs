using Microsoft.AspNetCore.Mvc;
using SuleymanSeyahat.Models.Siniflar;

namespace SuleymanSeyahat.Controllers
{
	public class BlogController : Controller
	{
		DataContext db;
		public BlogController(DataContext _db)
		{
			db = _db;
		}


		public IActionResult Index()
		{
			var degerler = db.Blogs.ToList();
			return View(degerler);
		}

		public IActionResult BlogDetay(int id) 
		{
			var blogbul = db.Blogs.Where(x => x.ID == id).ToList();

            return View(blogbul);
        }
	}
}
