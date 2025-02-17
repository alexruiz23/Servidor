using Peliculas.Models;

namespace Peliculas.Interfaces
{
    public interface IRepositorioInfoPeliculas
    {
        public List<infoPeliculas> GetInfo();
    }
}
