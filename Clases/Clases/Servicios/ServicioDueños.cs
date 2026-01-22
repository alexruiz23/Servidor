using Clases.Models;
using Microsoft.AspNetCore.Identity;

namespace Clases.Servicios
{
    public class ServicioDueños
    {
        

        using Clases.Interfaces;
using Clases.Models;

namespace Clases.Servicios
    {
        public class ServicioDueno : IDueñoS
        {
            public List<Dueño> getDueños()
            {
                return new List<Dueño>()
            {
                new Dueño()
                {
              
                    password = "Dueño@123",
                    nombre = "Juan",
                    apellidos = "Martínez López",
                    DNI = "12345678X",
                    telefono = "666-111-222",
                    email = "juan.martinez@email.com"
                },
                new Dueño()
                {
                 
                    password = "Dueño@456",
                    nombre = "María",
                    apellidos = "García Sánchez",
                    DNI = "87654321Y",
                    telefono = "666-333-444",
                    email = "maria.garcia@email.com"
                },
                new Dueño()
                {
                  
                    password = "Dueño@789",
                    nombre = "Carlos",
                    apellidos = "Ruiz Fernández",
                    DNI = "23456789Z",
                    telefono = "666-555-666",
                    email = "carlos.ruiz@email.com"
                },
                new Dueño()
                {
                   ,
                    password = "Dueño@101",
                    nombre = "Laura",
                    apellidos = "Pérez Moreno",
                    DNI = "34567890W",
                    telefono = "666-777-888",
                    email = "laura.perez@email.com"
                },
                new Dueño()
                {
          
                    password = "Dueño@202",
                    nombre = "Alberto",
                    apellidos = "Jiménez Torres",
                    DNI = "45678901V",
                    telefono = "666-999-000",
                    email = "alberto.jimenez@email.com"
                }
            };
            }
        }
    }

} }
