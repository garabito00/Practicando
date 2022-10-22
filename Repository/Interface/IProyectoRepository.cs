using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IProyectoRepository : IGenericRepository<Proyecto>
    {
        void Update(Proyecto proyecto);
    }
}
