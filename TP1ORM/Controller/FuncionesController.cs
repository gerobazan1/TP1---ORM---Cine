using System;
using System.Collections.Generic;
using TP1ORM.Application.Interfaces.IServices;
using TP1ORM.Application.Services;
using TP1ORM.Domain.Entities;
using TP1ORM.Presentation.UI;

namespace TP1ORM.Presentation.Controller
{
    public class FuncionesController
    {
        private readonly IPeliculaService _peliculaService;
        private readonly IFuncionesService _funcionesService;

        public FuncionesController(IPeliculaService peliculaService, IFuncionesService funcionesService)
        {
            _peliculaService = peliculaService;
            _funcionesService = funcionesService;
        }
        public void MostrarPeliculas()
        {
            Console.Clear();
            Banner.Cartelera();
            Console.WriteLine("");
            Console.WriteLine("     Peliculas en cartelera: ");
            Console.WriteLine("");
            var listaPeliculas = _peliculaService.ListarPeliculas();
            foreach (Peliculas pelicula in listaPeliculas)
            {
                Console.WriteLine("     " + pelicula.PeliculaId + ". " + pelicula.Titulo);
            }
        }
        public List<Peliculas> VerFuncionesPelicula(string nombrePelicula)
        {
            try
            {
                return _funcionesService.MostrarFunciones(nombrePelicula);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n    Ocurrió un error: " + ex.Message);
                return new List<Peliculas>();
            }
        }
    }
}
