using Models;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class ProyectoRepository : GenericRepository<Proyecto>, IProyectoRepository
    {
        private ApplicationDbContext _context;

        public ProyectoRepository(ApplicationDbContext context): base(context)
        {
            _context = context;
        }

        public void Update(Proyecto proyecto)
        {
            _context.proyectos.Update(proyecto);
        }
    }
}
