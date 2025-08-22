var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Ativar arquivos estáticos (wwwroot)
app.UseStaticFiles();

// Rota principal
app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html; charset=UTF-8";
    await context.Response.SendFileAsync("wwwroot/paginas/index.html");
});

app.Run();
