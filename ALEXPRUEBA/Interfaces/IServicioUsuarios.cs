using System;
using ALEXPRUEBA.Models;

namespace ALEXPRUEBA.Interfaces
{
	public interface IServicioUsuarios
	{
		public List<Alumno> getAlumnos();
        public Usuarios isUsuario(string usuario);
		public Usuarios isUsuario(string nick, string contra);
		public Boolean isRepetido(string nick, string contra);
		public void AñadirAlumno(Alumno a);

    } }

