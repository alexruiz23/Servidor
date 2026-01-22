using EjemploBBDDEF.Models;

namespace EjemploBBDDEF.Interfaces
{
    public interface IRepositoryCiclos
    {
        public List<Ciclo> GetCiclos();
        public List<Ciclo> GetCiclosByEspecialidad();
        public Ciclo FindCiclo(string siglas);
        public Ciclo FindCiclo(int id);
        public  Task AddCiclo(Ciclo c);
        public  Task DeleteCiclo(int id);
    }
}
