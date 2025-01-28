using Practica5.Data;
using Practica5.Interfaces;
using Practica5.Models;

namespace Practica5.Repositorios
{
    public class RepositoryCursos : ICurso
    {
        private ColegioContext _context;

        public RepositoryCursos(ColegioContext context)
        {
            _context = context;
        }


        public List<Curso> getCursosCiclo(string siglas)
        {
            return this._context.cursos.Where<Curso>(c => c.CicloCurso == siglas).ToList();
        }
    }
}
