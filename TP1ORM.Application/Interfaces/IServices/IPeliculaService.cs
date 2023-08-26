using System.Collections.Generic;
using TP1ORM.Domain.Entities;

namespace TP1ORM.Application.Interfaces.IServices
{
    public interface IPeliculaService
    {
        public List<Peliculas> ListarPeliculas();
        public Peliculas BuscarPelicula(string titulo);
    }
}
