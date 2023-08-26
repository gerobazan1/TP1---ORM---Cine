//using System;
//using TP1ORM.Domain.Entities;
//namespace TP1ORM.AccessData.Command
//{
//    public class AlquilerCommand
//    {
//        public LibreriaContext context = new LibreriaContext();
//        public bool CrearAlquiler(int ClienteId, string IsbnId, int EstadoId, DateTime? FechaReserva, DateTime? FechaAlquiler, DateTime? FechaDevolucion)
//        {
//            Alquiler alquiler = new Alquiler
//            {
//                ClienteId = ClienteId,
//                ISBN = IsbnId,
//                EstadoDeAlquilerId = EstadoId,
//                FechaReserva = FechaReserva,
//                FechaAlquiler = FechaAlquiler,
//                FechaDevolucion = FechaDevolucion
//            };
//            try
//            {
//                context.Alquileres.Add(alquiler);
//                context.SaveChanges();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }
//    }
//}
