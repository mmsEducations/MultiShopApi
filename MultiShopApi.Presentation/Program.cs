var builder = WebApplication.CreateBuilder(args);

//1.Ad�m MVC yap�s�n� dahil et
builder.Services.AddControllers();//Asp.Net Core MVC altyap�s�n� uygulamam�za dahil etmemizi sa�lar

//Swagger 1
builder.Services.AddEndpointsApiExplorer(); //Swaggerin apiyi incelemesi ve belgelerin olu�turulmas� 
builder.Services.AddSwaggerGen();//Swagger belgeleri i�in gerekli t�m ayarlar�n yap�land�r�lmas�



var app = builder.Build();

//Swagger 2
if (app.Environment.IsDevelopment())//Swagger'i Development sadecce ortam�nda aktifle�tirir
{
    app.UseSwagger();  //Apilerin yapt��� i�lemleri ve bu i�lemlerin nas�l kullan�laca��n� a��klayan metadalard�r 
    app.UseSwaggerUI();//Apilerin g�rsel ayarlamalar�'n� aktif hale getirir
}

//2.Ad�m MVC Controller'a Y�nlendirme
app.MapControllers(); //Asp.Net Core uygulamas�ndaki http isteklerini Api'nin Controller'�na y�nelerimeyi sa�lar

app.Run();
