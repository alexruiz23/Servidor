using Microsoft.EntityFrameworkCore;
using Practica5.Data;
using Practica5.Interfaces;
using Practica5.Repositorios;
using Practica5.Repositorios;
using static Practica5.Repositorios.RepositorioAlumnos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ColegioContext>(
options => {
    options.UseSqlServer("name = SqlColegio");

    });

builder.Services.AddTransient<ICiclo,RepositoryCiclos>();
builder.Services.AddTransient<IAlumno, RepositoryAlumnos>();
builder.Services.AddTransient<ICurso, RepositoryCursos>();
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
