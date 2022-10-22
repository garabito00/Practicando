using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        T FindOne(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
    }
}
