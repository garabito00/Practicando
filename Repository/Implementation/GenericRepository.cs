using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T FindOne(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = _dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }
    }
}
