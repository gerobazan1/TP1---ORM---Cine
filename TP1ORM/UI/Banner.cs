using System;

namespace TP1ORM.Presentation.UI
{
    public static class Banner
    {
        public static void MenuPrincipal()
        {
            Console.WriteLine("");
            Console.WriteLine("    ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("    ║                                              Bienvenido a CINEPOLIS                                          ║");
            Console.WriteLine("    ╠══════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("    ║                                                                                                              ║");
            Console.WriteLine("    ║  - Ingrese un número según lo que desea realizar.                                                            ║");
            Console.WriteLine("    ║                                                                                                              ║");
            Console.WriteLine("    ║  (1) Ver Peliculas disponibles.                                                                              ║");
            Console.WriteLine("    ║                                                                                                              ║");
            Console.WriteLine("    ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }

        public static void Cartelera()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("    ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("    ║                                              Cartelera de CINEPOLIS                                          ║");
            Console.WriteLine("    ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public static void DetallePelicula()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("    ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("    ║                                         Información sobre la PELICULA                                        ║");
            Console.WriteLine("    ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}