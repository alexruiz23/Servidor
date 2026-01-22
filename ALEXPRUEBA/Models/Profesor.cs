using ALEXPRUEBA.Models;
namespace ALEXPRUEBA.Models
{
    public class Profesor : Usuarios
	{
        public EnumeradoEspecialidad EspecialidadP { get; set; }
    }

    public enum EnumeradoEspecialidad
    {
        INFORMÁTICA,
        ADMINISTRACIÓN,
        MÁRKETING
    }
}


