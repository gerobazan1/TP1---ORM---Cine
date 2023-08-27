using Microsoft.Extensions.DependencyInjection;
using TP1ORM.AccessData.Queries;
using TP1ORM.AccessData;
using TP1ORM.Application.Interfaces.IQueries;
using TP1ORM.Application.Interfaces.IServices;
using TP1ORM.Application.Services;
using TP1ORM.Presentation.Controller;

namespace TP1ORM.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddTransient<IQueryPeliculas, QueryPeliculas>()
                .AddTransient<IPeliculaService, PeliculaService>()
                .AddTransient<IFuncionesService, FuncionesService>()
                .AddTransient<CineContext>()
                .AddTransient<PeliculaController>()
                .AddTransient<FuncionesController>()

                .AddTransient<Menu>()
                .BuildServiceProvider();

            Menu menu = serviceProvider.GetService<Menu>();
            menu.Desplegar();
        }
    }
}