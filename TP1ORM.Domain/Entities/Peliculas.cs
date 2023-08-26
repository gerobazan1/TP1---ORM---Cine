using System.Collections.Generic;

namespace TP1ORM.Domain.Entities
{
    public class Peliculas
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Poster { get; set; }
        public string Sinopsis { get; set; }
        public string Trailer { get; set; }

        public List<Funciones> FuncionesNavigator { get; set; }
    }
}
