using EjemploBBDDEF.Data;
using EjemploBBDDEF.Models;
using EjemploBBDDEF.Interfaces;

namespace EjemploBBDDEF.Repository
{
    public class RepositoryCursos: IRepositoryCursos
    {
        private ColegioContext _context;

        public RepositoryCursos(ColegioContext context)
        {
            _context = context;
        }


        public List<Curso> getCursosCiclo(string siglas)
        {
           return this._context.cursos.Where<Curso>(c=>c.CicloCurso== siglas).ToList();
        }
    }
}
