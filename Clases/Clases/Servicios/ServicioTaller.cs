using Clases.Interfaces;
using Clases.Models;

namespace Clases.Servicios
{
	public class ServicioTaller : ITallerS
	{
		public Taller GetTaller()
		{
			return new Taller()
			{
				nombre = "Taller Mecánico El Experto",
				direccion = "Av. Industrial 123",
				telefono = "555-1111",
				mecanicos = null,
				arreglos = null,
				coches = null
			};
		
		}
	}
}