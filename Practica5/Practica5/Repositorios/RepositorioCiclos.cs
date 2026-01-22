using Practica5.Data;
using Practica5.Interfaces;
using Practica5.Models;

namespace Practica5.Repositorios
{
    public class RepositoryCiclos : ICiclo
    {
        private ColegioContext context;

        public RepositoryCiclos(ColegioContext context)
        {
            this.context = context;
        }

        public List<Ciclo> GetCiclos()
        {
            // var sql = from datos in this.context.ciclos
            //select datos;
            //var c=this.context.ciclos.Where<Ciclo>(c => c.Siglas == "DAW");
            var x = this.context.Ciclos.ToList();
            return x;


            // return sql.ToList();
        }

        public List<Ciclo> GetCiclosByEspecialidad()
        {
            return this.context.Ciclos.OrderBy(c => c.Siglas).ToList();


        }

        public Ciclo FindCiclo(string siglas)
        {
            return this.context.Ciclos.FirstOrDefault<Ciclo>(c => c.Siglas == siglas);

        }

        

        public async Task AddCiclo(Ciclo c)
        {
            this.context.Ciclos.Add(c);
            await this.context.SaveChangesAsync();

        }

        public async Task DeleteCiclo(string siglas)
        {
            var c = this.context.Ciclos.FirstOrDefault<Ciclo>(c => c.Siglas == siglas);
            this.context.Ciclos.Remove(c);
            await this.context.SaveChangesAsync();
        }



    }
    }
