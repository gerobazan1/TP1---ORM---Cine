using System;
using TP1ORM.Application.Interfaces.IServices;
using TP1ORM.Domain.Entities;
using TP1ORM.Presentation.UI;

namespace TP1ORM.Presentation.Controller
{
    public class PeliculaController
    {
        private readonly IPeliculaService peliculaService;
        public PeliculaController(IPeliculaService service)
        {
            peliculaService = service;
        }

        public void MostrarPeliculas()
        {
            Console.Clear();
            Banner.Cartelera();
            Console.WriteLine("");
            Console.WriteLine("     Peliculas en cartelera: ");
            Console.WriteLine("");
            System.Collections.Generic.List<Peliculas> listaPeliculas = peliculaService.ListarPeliculas();
            foreach (Peliculas pelicula in listaPeliculas)
            {
                Console.WriteLine("     " + pelicula.PeliculaId + ". " + pelicula.Titulo);
            }
        }

        public void VerInformacionPelicula()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("     ---------------------------------------------------------------------------------------------------------------");
                string respuesta;
                do
                {
                    Console.WriteLine("\n     Desea ver más información sobre alguna película? 'Si' o 'No'");
                    respuesta = Console.ReadLine().ToLower();
                    if (respuesta == "si")
                    {
                        string response;
                        Peliculas pelicula = null;
                        do
                        {
                            Console.WriteLine("\n     Ingrese el nombre de la película que desea consultar información: \n");
                            response = Console.ReadLine();
                            pelicula = peliculaService.BuscarPelicula(response);
                            if (pelicula == null)
                            {
                                Console.WriteLine("\n     Película no encontrada. Intente nuevamente.");
                            }
                        } while (pelicula == null || !response.Trim().Equals(pelicula.Titulo, StringComparison.InvariantCultureIgnoreCase));

                        Console.Clear();
                        Banner.DetallePelicula();
                        Console.WriteLine("\n     Título: " + pelicula.Titulo + "\n     Poster: " + pelicula.Poster +
                                            "\n     Sinopsis: " + pelicula.Sinopsis + "\n     Trailer: " + pelicula.Trailer);

                        Console.WriteLine("\n     Presione la tecla ENTER para regresar al menú principal...");
                        _ = Console.ReadKey();

                        break;
                    }
                    else if (respuesta != "no")
                    {
                        Console.WriteLine("    Opción inválida. Por favor, ingrese 'Si' o 'No'.");
                    }
                } while (respuesta != "no");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n    Ocurrió un error: " + ex.Message);
            }
        }
    }
}
