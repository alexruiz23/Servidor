using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo.Modelos
{
    internal class Alumno
    {
        private string dni;
        private string nombre;
        private string telefono;

        public string DNI { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public Alumno(string dni,string nombre,string telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono= telefono;
        }
    }
}
