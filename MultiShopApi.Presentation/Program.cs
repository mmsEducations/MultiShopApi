var builder = WebApplication.CreateBuilder(args);

//1.Ad�m MVC yap�s�n� dahil et
builder.Services.AddControllers();//Asp.Net Core MVC altyap�s�n� uygulamam�za dahil etmemizi sa�lar

var app = builder.Build();

//2.Ad�m MVC Controller'a Y�nlendirme
app.MapControllers(); //Asp.Net Core uygulamas�ndaki http isteklerini Api'nin Controller'�na y�nelerimeyi sa�lar

app.Run();
