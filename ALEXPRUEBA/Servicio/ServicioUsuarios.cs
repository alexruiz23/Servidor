using ALEXPRUEBA.Interfaces;
using ALEXPRUEBA.Models;
namespace ALEXPRUEBA.Servicio
{
    public class ServicioUsuarios : IServicioUsuarios
    {

        //public List<Usuario> usuarios { get; set; }
        public List<Usuarios> usuarios = new List<Usuarios>();
        public ServicioUsuarios()
        {
            usuarios = new List<Usuarios>
                {
                    new Profesor
                    {
                        nombre = "Pedro D",
                        nick = "pdp",
                        contra = "a1234567",
                        email = "pdp@gmail.com",
                        EspecialidadP = EnumeradoEspecialidad.INFORMÁTICA
                    },
                    new Alumno
                    {
                        nombre = "Alex Ruix",
                        nick = "alexruix",
                        contra = "okupa",
                        email = "alexbrawl@gmail.com",
                        ciclo = EnumeradoCiclo.FINANZAS,
                        curso = 1,
                        idiomas = new List<string> { "español", "frances" }
                    }
                };
        }





            public List<Alumno> getAlumnos()

        {
            List<Alumno> alumnos = new List<Alumno>();
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i] is Alumno a)
                {
                    alumnos.Add(a);
                }
            }
            return alumnos;
        }
        public Usuarios isUsuario(string email)
        {
            //Usuario usucorreo = new Usuario();
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].email == email)
                {
                    return usuarios[i];
                }
            }
            return null;
        }
        //lo puedes llamar igual
        public Usuarios isUsuario(string usuario, string contra)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].nick == usuario && usuarios[i].contra==contra)
                {
                    return usuarios[i];
                }
            }
            return null;
        }

        public Boolean isRepetido(string nick, string contra)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].nick == nick && usuarios[i].contra == contra)
                {
                    return true;
                }
            }
            return false;
        }

        public void AñadirAlumno(Alumno a)
        {
            usuarios.Add(a);


        }
        

    }
}

