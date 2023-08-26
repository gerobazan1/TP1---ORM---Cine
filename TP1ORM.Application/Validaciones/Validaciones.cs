using System;
using System.Text.RegularExpressions;

namespace TP1ORM.Application.Validaciones
{
    public class Validar
    {
        //public Response ValidarDni(string dni)
        //{
        //    var response = new Response(true, "El dni ingresado no está registrado en la base de datos");
        //    if (!Regex.IsMatch(dni, @"^[0-9]+$"))
        //    {
        //        response.Content = "Por favor ingrese solo números \n ";
        //        response.Succes = false;
        //        return response;
        //    }
        //    var queryCliente = new QueryCliente();
        //    var clienteEncontrado = queryCliente.GetClienteDni(dni);
        //    if (clienteEncontrado != null)
        //    {
        //        response.Objects = clienteEncontrado;
        //        response.Content = "El dni ya existe en la base de datos";
        //        response.Succes = false;
        //        return response;
        //    }
        //    return response;
        //}
        //public Response ValidarISBN(string isbn)
        //{
        //    var response = new Response(true, "El ISBN ingresado no está registrado en la base de datos");
        //    if (!Regex.IsMatch(isbn, @"^[0-9]+$"))
        //    {
        //        response.Content = "Por favor ingrese solo números \n ";
        //        response.Succes = false;
        //        return response;
        //    }
        //    var queryLibro = new QueryLibro();
        //    var libroEncontrado = queryLibro.ListarLibros(isbn);
        //    if (libroEncontrado != null)
        //    {
        //        response.Objects = libroEncontrado;
        //        response.Content = "El ISBN ingresado es correcto";
        //        response.Succes = false;
        //        return response;
        //    }
        //    return response;
        //}
        public static string Caracteres(string cadena)
        {
            while (!Regex.IsMatch(cadena, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("\n Por favor ingrese solo letras.");
                cadena = Console.ReadLine();
            }
            return cadena;
        }
        public static string Email(string cadena)
        {
            while (!Regex.IsMatch(cadena, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                Console.WriteLine("\n - Formato incorrecto.\n" +
                                  " - Por favor ingrese un email valido: ");
                cadena = Console.ReadLine();
            }
            return cadena;
        }
        public static int ValidarNumero(string opcion)
        {
            bool numero;
            numero = int.TryParse(opcion, out _);
            while (!numero)
            {
                Console.Write("\n Por favor ingrese una opción valida: \n");
                opcion = Console.ReadLine();
                numero = int.TryParse(opcion, out _);
            }
            return int.Parse(opcion);
        }
        public static void OpcionInvalida()
        {
            Console.Write("\n Por favor ingrese una opción valida.");
            Console.Write("\n Presione ENTER para regresar al menú.\n");
            _ = Console.ReadLine();
        }
    }
}