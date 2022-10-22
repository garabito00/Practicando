using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IPosicionRepository: IGenericRepository<Posicion>
    {
        void Update(Posicion posicion);
        IEnumerable<Posicion> PosicionesConProyecto();
    }
}
