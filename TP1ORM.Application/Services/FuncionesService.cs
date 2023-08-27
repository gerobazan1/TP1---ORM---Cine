using System;
using System.Collections.Generic;
using System.Text;
using TP1ORM.Application.Interfaces.IQueries;
using TP1ORM.Application.Interfaces.IServices;
using TP1ORM.Domain.Entities;

namespace TP1ORM.Application.Services
{
    public class FuncionesService : IFuncionesService
    {
        private readonly IQueryPeliculas queryPeliculas;
        public FuncionesService(IQueryPeliculas query)
        {
            queryPeliculas = query;
        }

        public List<Peliculas> MostrarFunciones(string title)
        {
            return queryPeliculas.MostrarFunciones(title);
        }
    }
}
