using EjemploBBDDEF.Models;

namespace EjemploBBDDEF.Interfaces
{
    public interface IRepositoryAlumnos
    {
        public List<Alumno> getAlumnosCiclo(string siglas);
        public List<Alumno> getAlumnosCicloByCurso(string siglas);
        public  Task<int> addAlumnos(Alumno a);
        public Alumno findAlumno(string dni);
    }
}
