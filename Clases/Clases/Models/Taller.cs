using System.Collections.Generic;

namespace Clases.Models
{
	public class Taller
	{
		public List<Mecanico> mecanicos { get; set; }
		public List<Arreglos> arreglos { get; set; }
		public List<Coche> coches { get; set; }
		public string nombre { get; set; }
			public string direccion { get; set; }
			public string telefono { get; set; }
	}
}
