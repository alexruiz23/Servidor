using EjemploBBDDEF.Models;

namespace EjemploBBDDEF.Interfaces
{
    public interface IRepositoryCursos
    {
        public List<Curso> getCursosCiclo(string siglas);

    }
}
