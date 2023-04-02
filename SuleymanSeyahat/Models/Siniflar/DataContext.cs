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

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Blog>().HasData(
			new Blog { ID = 4, Baslik = "elma",  Aciklama = "Aciklama1", BlogImage = "images/service-icon-01.png" },
			new Blog { ID = 5, Baslik = "armut", Aciklama = "Aciklama2", BlogImage = "images/service-icon-03.png" },
			new Blog { ID = 6, Baslik = "ayva",  Aciklama = "Aciklama3", BlogImage = "images/service-icon-01.png" },
			new Blog { ID = 7, Baslik = "karpuz",Aciklama = "Aciklama4", BlogImage = "images/service-icon-02.png" },
			new Blog { ID = 8, Baslik = "erik",  Aciklama = "Aciklama5", BlogImage = "images/service-icon-01.png" },
			new Blog { ID = 9, Baslik = "muz",   Aciklama = "Aciklama6", BlogImage = "images/service-icon-03.png" }
		);

	}
}
