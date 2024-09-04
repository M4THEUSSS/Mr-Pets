var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto WEB Mr-Pets - version 1.0);

app.UseStaticFiles();

app.Run();
