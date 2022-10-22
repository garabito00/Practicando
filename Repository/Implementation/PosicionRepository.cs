using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class PosicionRepository : GenericRepository<Posicion>, IPosicionRepository
    {
        private ApplicationDbContext _context;

        public PosicionRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }

        public IEnumerable<Posicion> PosicionesConProyecto()
        {
            var query = _context.posiciones.Include(p => p.Proyecto);
            return query;
        }

        public void Update(Posicion posicion)
        {
            _context.posiciones.Update(posicion);
        }
    }
}
