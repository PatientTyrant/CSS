var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();   // wwwroot klas�r� i�erisindeki static dosyalar� eri�ime a�ar

app.MapGet("/", () => "Hello World!");

app.Run();
