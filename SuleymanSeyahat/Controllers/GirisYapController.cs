using Microsoft.AspNetCore.Mvc;
using SuleymanSeyahat.Models.Siniflar;

namespace SuleymanSeyahat.Controllers
{
	public class GirisYapController : Controller
	{

		DataContext c = new DataContext();
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Login()
		{
			return View();
		}

		//[HttpPost]
		//public ActionResult Login(Admin ad)  //admin sınıfından ad nesnesi türettik.
		//{
		//	var bilgiler c.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);  //bu linq sorgumuz kullanıcı ad. dan gelen kullanıcı ve şifreye eşitse sağlanıyorsa true gelecek. allta if eğer..
		//	if (bilgiler != null)  // .bilgiler farklıysa nulldan farklıysa 
		//	{

		//		Authentication.SetAuthCookie(bilgiler.Kullanici, false);
		//		Session["Kullanici"] = bilgiler.Kullanici.ToString();
		//		return RedirectToAction("Index", "Admin");   //bilgiler null değilse bunlar olacak
		//	}
		//	else //null da eğer sayfayı döndür kull adı ve şifre doğru değilse aynı sayfa ya döndür
		//	{
		//		{
		//			return View();
		//		}

		//	}
		//}
	}
}
