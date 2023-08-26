using System;
using TP1ORM.Application.Interfaces.IServices;
using TP1ORM.Application.Validaciones;
using TP1ORM.Presentation.Controller;
using TP1ORM.Presentation.UI;
namespace TP1ORM.Presentation
{
    public class Menu
    {
        private readonly IPeliculaService peliculaService;
        public Menu(IPeliculaService service)
        {
            peliculaService = service;
        }
        public void Desplegar()
        {
            bool estado = true;
            do
            {
                Console.Clear();
                Banner.MenuPrincipal();
                string opcion = Console.ReadLine();
                switch (Validar.ValidarNumero(opcion))
                {
                    case 1:
                        {
                            PeliculaController peliculaController = new PeliculaController(peliculaService);
                            peliculaController.MostrarPeliculas();
                            peliculaController.VerInformacionPelicula();
                            break;
                        }
                    default:
                        {
                            Validar.OpcionInvalida();
                            break;
                        }
                }
            } while (estado);
        }
    }
}