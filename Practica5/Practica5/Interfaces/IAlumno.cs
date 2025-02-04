
using Practica5.Models;
namespace Practica5.Interfaces
{
    public interface IAlumno
    {
        public List<Alumno> getAlumnosCiclo(string siglas);
        public List<Alumno> getAlumnosCicloByCurso(string siglas);
        public Task<int> addAlumnos(Alumno a);
        public Alumno findAlumno(string dni);

        
    }
}
