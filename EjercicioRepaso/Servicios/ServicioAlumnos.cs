using System;
using EjercicioRepaso.Interfaz;

namespace EjercicioRepaso.Servicios
{
	public class ServicioAlumnos : IAlumno
	{
        private List<Alumno> alumnos;

        public ServicioAlumnos()
        {
            // Inicialización con algunos datos de ejemplo
                    alumnos = new List<Alumno>
                {
                    new Alumno
                    {
                        dni = "12345678A",
                        Nombre = "Juan",
                        Apellidos = "García Pérez",
                        Telefono = "666123456",
                        Curso = "1º DAM",
                        Edad = 18
                    },
                    new Alumno
                    {
                        dni = "87654321B",
                        Nombre = "María",
                        Apellidos = "Rodriguez Sánchez",
                        Telefono = "677234567",
                        Curso = "2º DAW",
                        Edad = 20
                    }
                };
        }


        public List<Alumno> ObtenerTodosLosAlumnos()
        {
            return alumnos;
        }

        public Alumno AlumnoId(int id)
        {
            return alumnos[id];
        }

        public List<Alumno> addAlumno(Alumno a)
        {
            alumnos.Add(a);
            return alumnos;

        }

        public Alumno buscarporDNI(Alumno a)
        {
            for(int i = 0;i<alumnos.Count; i++)
            {
                if (alumnos[i].Nombre == a.Nombre)
                {
                    return alumnos[i];
                }
              
            }
            return null;
         
        }
        public void borrarporDNI(Alumno a)
        {
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].Nombre == a.Nombre)
                {
                    alumnos.Remove(alumnos[i]);
                    break;
                }

            }
           

        }

      
    }


   
   




}

