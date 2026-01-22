using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones.excepciones
{
    public class DatosErrorExcepcion: Exception
    {
        public DatosErrorExcepcion(string message) : base(message) { }
    }
}
