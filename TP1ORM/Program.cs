using Microsoft.Extensions.DependencyInjection;
using TP1ORM.AccessData;
using TP1ORM.AccessData.Queries;
using TP1ORM.Application.Interfaces.IQueries;
using TP1ORM.Application.Interfaces.IServices;
using TP1ORM.Application.Services;

namespace TP1ORM.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddTransient<IQueryPeliculas, QueryPeliculas>()
                .AddTransient<IPeliculaService, PeliculaService>()
                .AddTransient<CineContext>()
                .AddTransient<Menu>()
                .BuildServiceProvider();

            Menu menu = serviceProvider.GetService<Menu>();
            menu.Desplegar();
        }
    }
}

//otra opcion de inyeccion de dependencias
//namespace TP1ORM
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {

//            using (var context = new CineContext())
//            {
//                // Crear instancias de implementaciones necesarias
//                IQueryPeliculas queryPeliculas = new QueryPeliculas(context);
//                IPeliculaService peliculaService = new PeliculaService(queryPeliculas);
//                Menu menu = new Menu(peliculaService);

//                menu.Desplegar();
//            }
//        }
//    }
//}

