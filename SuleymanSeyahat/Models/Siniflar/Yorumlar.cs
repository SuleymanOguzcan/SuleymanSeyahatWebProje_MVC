using System.ComponentModel.DataAnnotations;

namespace SuleymanSeyahat.Models.Siniflar
{
	public class Yorumlar
	{
		[Key]
		public int ID { get; set; }
		public string KullaniciAdi { get; set; }
		public string Mail { get; set; }
		public string Yorum { get; set; }
		
		public virtual Blog Blog { get; set; }   //burada Blog propertimiz Blog tablosundaki değeri tutuyo ama ilişki yorumlarda sağlanacak orayı düzenleyeceğim şimdi.
	}
}
