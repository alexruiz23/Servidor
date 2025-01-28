using Practica5.Models;
using Microsoft.EntityFrameworkCore;

namespace Practica5.Data
{
    public class ColegioContext: DbContext
    {

        public ColegioContext(DbContextOptions<ColegioContext> options) : base(options) { }
        public DbSet<Ciclo> ciclos { get; set; }

        public DbSet<Alumno> alumnos { get; set; }

        public DbSet<Curso> cursos { get; set; }
    }
}
