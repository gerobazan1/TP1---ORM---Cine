using System.Collections.Generic;
using TP1ORM.Domain.Entities;

namespace TP1ORM.Application.Interfaces.IQueries
{
    public interface IQueryPeliculas
    {
        public List<Peliculas> ListarPeliculas();
        public Peliculas BuscarPelicula(string titulo);
        public List<Peliculas> MostrarFunciones(string title);
    }
}
