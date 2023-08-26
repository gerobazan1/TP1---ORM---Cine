using System;
namespace TP1ORM.Domain.Entities
{
    public class Tickets
    {
        public string Usuario { get; set; }

        public Guid TicketId { get; set; }
        public int FuncionId { get; set; }

        public Funciones Funciones { get; set; }
    }
}