using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SuleymanSeyahat.Models.Siniflar;

var builder = WebApplication.CreateBuilder(args);  //kestel sunucu olu�turma k�sm�

// Add services to the container.
builder.Services.AddControllersWithViews();  //burada mvc kullan�ca��m�z� belirttik.

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "MvcGiris.Auth";  //cookie ismi ben verdim..cookie tabanl� kimlik do�rulama
    options.LoginPath = "~/Login/Index";   //kullan�c� bilgisi bulunamazsa buraya y�nlendir.
    options.AccessDeniedPath= "~/Login/Index";  //yetkisiz kullan�c�ysa buraya gitsin..

});

//dependency Injection
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CS1"))); //burada sql e baglan diyoruz Datacontext �zerinden..

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())   // geli�tirme ortam�nda hata kodlar�n� a��k g�nder yoksa home error a d�n..
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//alttaki k�s�mlar middleware yap�s�n� olu�turuyor. aut i�lemleri loglama vs.. middleware yap�s� �stten a�a�� do�ru �al���r kontrol ederek.
app.UseHttpsRedirection();
app.UseStaticFiles();  //wwwroot daki dosyalar� taramak i�in..

app.UseRouting();  //normalde product/index yapt�ksak onu url de �r�n/sayfa yap bu seo yada yard�mc� oluyor..


app.UseAuthentication();  //buray� �stte cookielerden sonra atad�k. di�er t�m k�s�mlar default geliyor.
app.UseAuthorization();   // ve middleware gere�i ilk authen i kontol eder(kullan�c�y�) sonra authoru (bilgileri) kontrol eder.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



//burada middleware de s�ralama �nemli . s�rayla kontrol eder ve app.run la proje aya�a kalkar..