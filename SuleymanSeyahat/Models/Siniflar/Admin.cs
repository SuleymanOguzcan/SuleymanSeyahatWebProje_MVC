using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuleymanSeyahat.Models.Siniflar
{
	public class Admin
	{
		[Key]
		public int Id { get; set; }

		[Column (TypeName ="Varchar(50)"), Required(ErrorMessage ="Admin adı boş bırakılamaz"), 
			Display(Name ="Admin Adı")]  //data annotation larımız..
		public string Kullanici { get; set; }
		
		public string Sifre { get; set; }
	}
}
