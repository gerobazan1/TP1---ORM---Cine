using System.Collections.Generic;
using System.Linq;
using TP1ORM.Application.Interfaces.IQueries;
using TP1ORM.Domain.Entities;

namespace TP1ORM.AccessData.Queries
{
    public class QueryPeliculas : IQueryPeliculas
    {
        private readonly CineContext context;
        public QueryPeliculas(CineContext context)
        {
            this.context = context;
        }

        public List<Peliculas> ListarPeliculas()
        {
            return context.Peliculas.ToList();
        }

        public Peliculas BuscarPelicula(string titulo)
        {
            return context.Peliculas.Where(l => l.Titulo == titulo).FirstOrDefault();
        }
    }
}
