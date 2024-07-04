var builder = WebApplication.CreateBuilder(args);

//1.Adým MVC yapýsýný dahil et
builder.Services.AddControllers();//Asp.Net Core MVC altyapýsýný uygulamamýza dahil etmemizi saðlar

var app = builder.Build();

//2.Adým MVC Controller'a Yönlendirme
app.MapControllers(); //Asp.Net Core uygulamasýndaki http isteklerini Api'nin Controller'ýna yönelerimeyi saðlar

app.Run();
