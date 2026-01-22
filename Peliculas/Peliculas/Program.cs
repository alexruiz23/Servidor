using Microsoft.EntityFrameworkCore;
using Peliculas.Data;
using Peliculas.Interfaces;
using Peliculas.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DBContext>(
options => {
    options.UseSqlServer("name = SqlColegio");

});

builder.Services.AddTransient<IRepositorioGenero, RepositorioGenero>();
builder.Services.AddTransient<IRepositorioInfoPeliculas, RepositorioInfoPeliculas>();
builder.Services.AddTransient<IRepositorioPeliculas,RepositorioPeliculas>();
var app = builder.Build();


// Add services to the container.



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
