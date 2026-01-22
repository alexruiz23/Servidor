using Clases.Interfaces;
using Clases.Models;

namespace Clases.Servicios
{
	public class ServicioCoche : ICochesS


	{
		public List<Coche> getCoche()
		{
			return new List<Coche>() {
	

	new Coche()
	{
		modelo = "Corolla",
		matricula = "1234 ABC",
		marca = "Toyota",
		año = 2020,
		img = "corolla_2020.jpg",
		dueños = new List<Dueño>
		{
			new Dueño()
			{
				nombre = "Juan",
				apellidos = "Martínez López",
				DNI = "12345678X",
				telefono = "666-111-222",
				email = "juan.martinez@email.com"
			}
		}
	},
	new Coche()
	{
		modelo = "Golf GTI",
		matricula = "5678 XYZ",
		marca = "Volkswagen",
		año = 2021,
		img = "golf_gti_2021.jpg",
		dueños = new List<Dueño>
		{
			new Dueño()
			{
				nombre = "María",
				apellidos = "García Sánchez",
				DNI = "87654321Y",
				telefono = "666-333-444",
				email = "maria.garcia@email.com"
			}
		}
	},
	new Coche()
	{
		modelo = "Serie 3",
		matricula = "9012 DEF",
		marca = "BMW",
		año = 2022,
		img = "bmw_serie3_2022.jpg",
		dueños = new List<Dueño>
		{
			new Dueño()
			{
				nombre = "Carlos",
				apellidos = "Ruiz Fernández",
				DNI = "23456789Z",
				telefono = "666-555-666",
				email = "carlos.ruiz@email.com"
			}
		}
	},
	new Coche()
	{
		modelo = "A180",
		matricula = "3456 GHI",
		marca = "Mercedes",
		año = 2021,
		img = "mercedes_a180_2021.jpg",
		dueños = new List<Dueño>
		{
			new Dueño()
			{
				nombre = "Laura",
				apellidos = "Pérez Moreno",
				DNI = "34567890W",
				telefono = "666-777-888",
				email = "laura.perez@email.com"
			}
		}
	},
	new Coche()
	{
		modelo = "Mustang",
		matricula = "7890 JKL",
		marca = "Ford",
		año = 2023,
		img = "mustang_2023.jpg",
		dueños = new List<Dueño>
		{
			new Dueño()
			{
				nombre = "Alberto",
				apellidos = "Jiménez Torres",
				DNI = "45678901V",
				telefono = "666-999-000",
				email = "alberto.jimenez@email.com"
			}
		}
	}
};
	}	}
	}

