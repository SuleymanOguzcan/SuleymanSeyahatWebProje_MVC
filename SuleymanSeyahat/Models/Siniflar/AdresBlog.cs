using System.ComponentModel.DataAnnotations;

namespace SuleymanSeyahat.Models.Siniflar
{
	public class AdresBlog
	{
		[Key]
		public int ID { get; set; }
		public string MyProperty { get; set; }
		public string Baslik { get; set; }
		public string Aciklama { get; set; }
		public string AdresAcik { get; set; }
		public string Mail { get; set; }
		public string Tel { get; set; }
		public string Konum { get; set; }
		
	}
}
