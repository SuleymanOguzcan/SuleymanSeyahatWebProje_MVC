using Microsoft.EntityFrameworkCore;

namespace SuleymanSeyahat.Models.Siniflar
{
	public class DataContext : DbContext  //EFCore'la geliyor DbContext mirası
	{
		

		public DataContext(DbContextOptions<DataContext> options) : base(options) //veritabanı nesnesi oluşturduk.. buradaki işlemle beraber program cs apsettşng ve bunu yazıp add-migration yaparak sql bağ. oluşturduk.
		{
		}  //constructor oluturuduk bunu controllerlarda kullanıcaz.datacontextte bir nesne ürettiğimizde burası çalışacak.. mesela Datacontex db= new Datacontex  dediğimizde burası çalışacak. 



		//tabloların oluşturulması
		public DbSet<Admin> Admins { get; set; }    //DbSet efcore dan geliyo
		public DbSet<AdresBlog> AdresBlogs { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Hakkimizda> Hakkimizdas { get; set; }
		public DbSet<iletisim> iletisims { get; set; }
		public DbSet<Yorumlar> Yorumlars { get; set; }
	}
}
