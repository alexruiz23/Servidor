using Microsoft.EntityFrameworkCore;
using Peliculas.Models;

namespace Peliculas.Data
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<Genero> generos { get; set; }

        public DbSet<infoPeliculas> infoPeliculas { get; set; }

        public DbSet<Pelicula> peliculas { get; set; }
    }
}
