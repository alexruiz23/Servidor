using Peliculas.Data;
using Peliculas.Interfaces;
using Peliculas.Models;

namespace Peliculas.Repository
{
    public class RepositorioGenero : IRepositorioGenero
    {

        private DBContext context;

        public RepositorioGenero(DBContext context)
        {
            this.context = context;
        }

        public List<Genero> GetG()
        {
            // var sql = from datos in this.context.ciclos
            //select datos;
            //var c=this.context.ciclos.Where<Ciclo>(c => c.Siglas == "DAW");
            var y = this.context.generos.ToList();
            return y;


            // return sql.ToList();
        }
    }
}
