using System;
using System.Collections.Generic;
using System.Text;
using TP1ORM.Domain.Entities;

namespace TP1ORM.Application.Interfaces.IServices
{
    public interface IFuncionesService
    {
        public List<Peliculas> MostrarFunciones(string title);
    }
}
