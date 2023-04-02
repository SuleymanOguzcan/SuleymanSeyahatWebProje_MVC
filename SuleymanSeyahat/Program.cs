using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SuleymanSeyahat.Models.Siniflar;

var builder = WebApplication.CreateBuilder(args);  //kestel sunucu oluþturma kýsmý

// Add services to the container.
builder.Services.AddControllersWithViews();  //burada mvc kullanýcaðýmýzý belirttik.

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "MvcGiris.Auth";  //cookie ismi ben verdim..cookie tabanlý kimlik doðrulama
    options.LoginPath = "~/Login/Index";   //kullanýcý bilgisi bulunamazsa buraya yönlendir.
    options.AccessDeniedPath= "~/Login/Index";  //yetkisiz kullanýcýysa buraya gitsin..

});

//dependency Injection
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CS1"))); //burada sql e baglan diyoruz Datacontext üzerinden..

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())   // geliþtirme ortamýnda hata kodlarýný açýk gönder yoksa home error a dön..
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//alttaki kýsýmlar middleware yapýsýný oluþturuyor. aut iþlemleri loglama vs.. middleware yapýsý üstten aþaðý doðru çalýþýr kontrol ederek.
app.UseHttpsRedirection();
app.UseStaticFiles();  //wwwroot daki dosyalarý taramak için..

app.UseRouting();  //normalde product/index yaptýksak onu url de ürün/sayfa yap bu seo yada yardýmcý oluyor..


app.UseAuthentication();  //burayý üstte cookielerden sonra atadýk. diðer tüm kýsýmlar default geliyor.
app.UseAuthorization();   // ve middleware gereði ilk authen i kontol eder(kullanýcýyý) sonra authoru (bilgileri) kontrol eder.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



//burada middleware de sýralama önemli . sýrayla kontrol eder ve app.run la proje ayaða kalkar..