using Clases.Interfaces;
using Clases.Models;

namespace Clases.Servicios
{
    public class ServicioMecanico : IMecanicoS
    {





        public List<Mecanico> getMecanicos()
        {
            return new List<Mecanico>()
            {
                new Mecanico
                {
                    usuario = "pruiz",
                    password = "Mec@nico1",
                    id = 1,
                    nombre = "Pedro",
                    apellidos = "Ruiz Martínez",
                    DNI = "12345678A",
                    fechaalata = new DateTime(2014, 3, 15),
                    email = "pedro.ruiz@talleres.com",
                    telefono = "666-111-222",
                    img = "pedro_ruiz.jpg"
                },
                new Mecanico
                {
                    usuario = "alopez",
                    password = "Mec@nico2",
                    id = 2,
                    nombre = "Ana",
                    apellidos = "López Sánchez",
                    DNI = "23456789B",
                    fechaalata = new DateTime(2018, 6, 22),
                    email = "ana.lopez@talleres.com",
                    telefono = "666-222-333",
                    img = "ana_lopez.jpg"
                },
                new Mecanico
                {
                    usuario = "cgarcia",
                    password = "Mec@nico3",
                    id = 3,
                    nombre = "Carlos",
                    apellidos = "García Fernández",
                    DNI = "34567890C",
                    fechaalata = new DateTime(2020, 8, 10),
                    email = "carlos.garcia@talleres.com",
                    telefono = "666-333-444",
                    img = "carlos_garcia.jpg"
                },
                new Mecanico
                {
                    usuario = "mtorres",
                    password = "Mec@nico4",
                    id = 4,
                    nombre = "María",
                    apellidos = "Torres González",
                    DNI = "45678901D",
                    fechaalata = new DateTime(2019, 11, 5),
                    email = "maria.torres@talleres.com",
                    telefono = "666-444-555",
                    img = "maria_torres.jpg"
                },
                new Mecanico
                {
                    usuario = "jmartin",
                    password = "Mec@nico5",
                    id = 5,
                    nombre = "José",
                    apellidos = "Martín Rodríguez",
                    DNI = "56789012E",
                    fechaalata = new DateTime(2021, 4, 20),
                    email = "jose.martin@talleres.com",
                    telefono = "666-555-666",
                    img = "jose_martin.jpg"
                },
                new Mecanico
                {
                    usuario = "lsanz",
                    password = "Mec@nico6",
                    id = 6,
                    nombre = "Laura",
                    apellidos = "Sanz Pérez",
                    DNI = "67890123F",
                    fechaalata = new DateTime(2017, 9, 30),
                    email = "laura.sanz@talleres.com",
                    telefono = "666-666-777",
                    img = "laura_sanz.jpg"
                }
            };
        }
    }


    public boolean isLogin(LoginViewModel l)
    {
        //recorre lista buscando usuario
    }

}