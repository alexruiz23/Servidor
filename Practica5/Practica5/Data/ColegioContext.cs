using Practica5.Models;
using Microsoft.EntityFrameworkCore;

namespace Practica5.Data
{
    public class ColegioContext: DbContext
    {

        public ColegioContext(DbContextOptions<ColegioContext> options) : base(options) { }
        public DbSet<Ciclo> Ciclos { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Curso> Cursos { get; set; }
    }
}
