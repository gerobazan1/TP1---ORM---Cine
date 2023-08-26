using System.Collections.Generic;
using TP1ORM.Application.Interfaces.IQueries;
using TP1ORM.Application.Interfaces.IServices;
using TP1ORM.Domain.Entities;

namespace TP1ORM.Application.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IQueryPeliculas queryPeliculas;
        public PeliculaService(IQueryPeliculas query)
        {
            queryPeliculas = query;
        }

        public List<Peliculas> ListarPeliculas()
        {
            return queryPeliculas.ListarPeliculas();
        }
        public Peliculas BuscarPelicula(string titulo)
        {
            return queryPeliculas.BuscarPelicula(titulo);
        }
        public List<Peliculas> BuscarPeliculas(string titulo)
        {
            return queryPeliculas.ListarPeliculas();
        }
    }
}