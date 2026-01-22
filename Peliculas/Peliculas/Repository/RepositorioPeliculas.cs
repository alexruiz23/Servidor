using Peliculas.Data;
using Peliculas.Interfaces;
using Peliculas.Models;

namespace Peliculas.Repository
{
    public class RepositorioPeliculas : IRepositorioPeliculas
    {
         
        private DBContext context;

        public RepositorioPeliculas(DBContext context)
        {
            this.context = context;
        }

        public List<Pelicula> GetP()
        {
            // var sql = from datos in this.context.ciclos
            //select datos;
            //var c=this.context.ciclos.Where<Ciclo>(c => c.Siglas == "DAW");
            var y = this.context.peliculas.ToList();
            return y;


            // return sql.ToList();
        }
    
}
}
