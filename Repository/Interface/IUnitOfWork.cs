using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IUnitOfWork
    {
        void Save();
        IProyectoRepository Proyecto { get; }
        IPosicionRepository Posicion { get; }
    }
}
