var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();   // wwwroot klasörü içerisindeki static dosyalarý eriþime açar

app.MapGet("/", () => "Hello World!");

app.Run();
