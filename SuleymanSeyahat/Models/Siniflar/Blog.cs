using System.ComponentModel.DataAnnotations;

namespace SuleymanSeyahat.Models.Siniflar
{
	public class Blog
	{
		[Key]
		public int ID { get; set; }
		public string Baslik { get; set; }
		public DateTime Tarih { get; set; }
		public string Aciklama { get; set; }
		public string BlogImage { get; set; }
		public ICollection<Yorumlar> Yorumlars { get; set; }		//bloglar tablosunda bire çok ilişki oluştu.  bir blogun birden fazla yorumu olabilir bir yorum sadece bir blog için geçerlidir.
	}
}
