using System.Collections.Generic;
namespace TP1ORM.Domain.Entities
{
    public class Sala
    {
        public int SalaId { get; set; }
        public int Capacidad { get; set; }

        public List<Funciones> FuncionesNavigator { get; set; }
    }
}
