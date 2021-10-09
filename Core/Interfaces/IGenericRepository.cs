using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Interfaces
{
   public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(string[] includes = null);
        T GetById(object id);
        T Find(Expression<Func<T,bool>> expression,string[] includes = null);
        IEnumerable<T> FindAll(Expression<Func<T,bool>> expression,string[] includes = null);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);


    }
}
