using System;
using System.Collections.Generic;
namespace TP1ORM.Domain.Entities
{
    public class Funciones
    {
        public int FuncionId { get; set; }
        public int PeliculaId { get; set; }
        public int SalaId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Horario { get; set; }

        public Peliculas Peliculas { get; set; }
        public Sala Sala { get; set; }
        public List<Tickets> TicketsNavigator { get; set; }
    }
}