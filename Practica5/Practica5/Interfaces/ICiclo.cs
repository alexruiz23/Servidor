using Practica5.Models;

namespace Practica5.Interfaces
{
    public interface ICiclo
    {
        public List<Ciclo> GetCiclos();
        public List<Ciclo> GetCiclosByEspecialidad();
        public Ciclo FindCiclo(string siglas);
        public Task AddCiclo(Ciclo c);
    }
}