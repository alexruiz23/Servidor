using System;
namespace ALEXPRUEBA.Models

{
    public class Alumno : Usuarios
	{
		public EnumeradoCiclo ciclo{ get; set; }
        public int curso { get; set; }
        //mirar que el curso sea 1 o 2
        public List<string> idiomas { get; set; }
    }

	public enum EnumeradoCiclo
	{
        DAW,      //0
		ASIR,     //1
		FINANZAS, //2
		MARKETING //3
    }
}

