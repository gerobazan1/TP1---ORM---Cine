﻿using System;
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
            var listaPeliculas = peliculaService.ListarPeliculas();
            foreach (Peliculas pelicula in listaPeliculas)
            {
                Console.WriteLine("     " + pelicula.PeliculaId + ". " + pelicula.Titulo);
            }
        }
        public Peliculas VerInformacionPelicula(string nombrePelicula)
        {
            try
            {
                return peliculaService.BuscarPelicula(nombrePelicula);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n    Ocurrió un error: " + ex.Message);
                return new Peliculas { PeliculaId = -1, Titulo = "Error de búsqueda" };
            }
        }
    }
}
