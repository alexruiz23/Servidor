using System;
namespace EjercicioRepaso.Interfaz
{
	public interface IAlumno
	{
        public List<Alumno> ObtenerTodosLosAlumnos();
        public List<Alumno> addAlumno(Alumno a);
        public Alumno AlumnoId(int id);
        public Alumno buscarporDNI(Alumno a);
        public void borrarporDNI(Alumno a);
    }
}

