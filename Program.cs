

using Microsoft.EntityFrameworkCore;
using minimal_api.Infraestrutura.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options => {
    options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    );
});

var app = builder.Build();



app.MapGet("/", () => "olá mundo!");

app.MapPost("/login", (minimal_api.Dominio.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
    {
        return Results.Ok("login com sucesso");
    }
    else
    {
        return Results.Unauthorized();
    }
});


app.Run();

