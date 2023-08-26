//using System;
//using TP1ORM.Domain.Entities;
//namespace TP1ORM.AccessData.Command
//{
//    public class ClienteCommand
//    {
//        public LibreriaContext context = new LibreriaContext();
//        public void CrearCliente(string DNI, string Nombre, string Apellido, string Email)
//        {
//            var cliente = new Funciones
//            {
//                DNI = DNI,
//                Nombre = Nombre,
//                Apellido = Apellido,
//                Email = Email
//            };
//            try
//            {
//                context.Clientes.Add(cliente);
//                context.SaveChanges();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("\n Ha ocurrido un error: " + e.Message);
//            }
//        }
//    }
//}
