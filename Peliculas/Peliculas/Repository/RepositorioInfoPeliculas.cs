using Peliculas.Data;
using Peliculas.Interfaces;
using Peliculas.Models;

namespace Peliculas.Repository
{
    public class RepositorioInfoPeliculas : IRepositorioInfoPeliculas
    {
        private DBContext context;

        public RepositorioInfoPeliculas(DBContext context)
        {
            this.context = context;
        }

        public List<infoPeliculas> GetInfo()
        {
            // var sql = from datos in this.context.ciclos
            //select datos;
            //var c=this.context.ciclos.Where<Ciclo>(c => c.Siglas == "DAW");
            var x = this.context.infoPeliculas.ToList();
            return x;


            // return sql.ToList();
        }
    }
}
