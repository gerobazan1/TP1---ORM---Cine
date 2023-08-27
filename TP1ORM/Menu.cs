using System;
using TP1ORM.Application.Validaciones;
using TP1ORM.Presentation.Actions;
using TP1ORM.Presentation.Controller;
using TP1ORM.Presentation.UI;

namespace TP1ORM.Presentation
{
    public class Menu
    {
        private readonly MenuActions menuActions;
        public Menu(PeliculaController peliculaController, FuncionesController funcionesController)
        {
            menuActions = new MenuActions(peliculaController, funcionesController);
        }

        public void Desplegar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Banner.MenuPrincipal();
                string opcion = Console.ReadLine();

                switch (Validar.ValidarNumero(opcion))
                {
                    case 1:
                        menuActions.MostrarPeliculas();
                        break;
                    case 2:
                        menuActions.MostrarFunciones();
                        break;
                    default:
                        Validar.OpcionInvalida();
                        break;
                }
            }
        }
    }
}