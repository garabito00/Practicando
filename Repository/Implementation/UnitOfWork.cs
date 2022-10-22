using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Proyecto = new ProyectoRepository(context);
            Posicion = new PosicionRepository(context);
        }
        public IProyectoRepository Proyecto { get; private set;}
        public IPosicionRepository Posicion { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
