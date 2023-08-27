using System;
using TP1ORM.Domain.Entities;
using TP1ORM.Presentation.Controller;
using TP1ORM.Presentation.UI;

namespace TP1ORM.Presentation.Actions
{
    public class MenuActions
    {
        private readonly PeliculaController _peliculaController;
        private readonly FuncionesController _funcionesController;

        public MenuActions(PeliculaController peliculaController, FuncionesController funcionesController)
        {
            _peliculaController = peliculaController;
            _funcionesController = funcionesController;
        }
        #region Peliculas
        public void MostrarPeliculas()
        {
            string respuesta;
            do
            {
                _peliculaController.MostrarPeliculas();
                Console.WriteLine("\n     Desea ver más información sobre alguna película? 'Si' o 'No'");
                respuesta = Console.ReadLine().ToLower();

                if (respuesta == "si")
                {
                    MostrarInformacionPelicula(_peliculaController);
                    break;
                }
                else if (respuesta != "no")
                {
                    Console.WriteLine("     Opción inválida. Por favor, ingrese 'Si' o 'No'.");
                }

            } while (respuesta != "no");
        }

        public void MostrarInformacionPelicula(PeliculaController peliculaController)
        {
            bool peliculaEncontrada = false;
            do
            {
                Console.WriteLine("\n     Ingrese el nombre de la película que desea consultar información:");
                string respuesta = Console.ReadLine();

                Peliculas pelicula = peliculaController.VerInformacionPelicula(respuesta);
                if (pelicula != null)
                {
                    Console.Clear();
                    Banner.DetallePelicula();
                    Console.WriteLine($"     Título: {pelicula.Titulo}\n     Poster: {pelicula.Poster}\n     Sinopsis: {pelicula.Sinopsis}\n     Trailer: {pelicula.Trailer}");
                    Console.WriteLine("\n     Presione la tecla ENTER para regresar al menú principal...");
                    Console.ReadKey();
                    peliculaEncontrada = true;
                }
                else
                {
                    Console.WriteLine("\n     La Película ingresada no fue encontrada. Intente nuevamente.");
                }

            } while (!peliculaEncontrada);
        }
        #endregion
        #region Funciones
        public void MostrarFunciones()
        {
            do
            {
                _funcionesController.MostrarPeliculas();
                Console.WriteLine("\n     Ingrese el nombre de la película de la cual desea consultar las funciones disponibles:");
                string respuesta = Console.ReadLine();
                var funcionPeliculas = _funcionesController.VerFuncionesPelicula(respuesta);

                if (funcionPeliculas != null && funcionPeliculas.Count > 0)
                {
                    Console.Clear();
                    Banner.FuncionesPelicula();

                    foreach (var pelicula in funcionPeliculas)
                    {
                        Console.WriteLine("\n     Las funciones disponibles: ");
                        Console.WriteLine("\n     Nombre: " + pelicula.Titulo);
                        Console.WriteLine("\n     Funciones: ");

                        foreach (var peli in pelicula.FuncionesNavigator)
                        {
                            Console.Write("\n     Número de función: " + peli.FuncionId + "\n Fecha: " +
                                          peli.Fecha.ToShortDateString() + "\n Horario: " +
                                          (peli.Horario.ToString("hh\\:mm") + "\n") + "\n");
                        }
                    }
                    Console.WriteLine("\n     Presione la tecla ENTER para regresar al menú principal...");
                    Console.ReadKey();
                    break; 
                }
                else
                {
                    Console.WriteLine("\n     La Película ingresada no fue encontrada. ¿Desea intentar nuevamente? (s/n)");
                    string respuestaUsuario = Console.ReadLine();
                    if (respuestaUsuario.ToLower() != "s")
                    {
                        break; 
                    }
                }
            } while (true);
        }
        #endregion

    }
}
