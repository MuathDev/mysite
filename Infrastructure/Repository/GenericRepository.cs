﻿using Core.Interfaces;
using Infastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private DbSet<T> table = null;
        public GenericRepository(DataContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = GetById(id);
            table.Remove(existing);
        }

        public T Find(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            IQueryable<T> Query = table;
            if (includes != null)
                foreach (var include in includes)
                    Query = Query.Include(include);
            return Query.SingleOrDefault(expression);
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            IQueryable<T> Query = table;
            if (includes != null)
                foreach (var include in includes)
                    Query = Query.Include(include);
            return Query.Where(expression).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            IQueryable<T> Query = table;
            if (includes != null)
                foreach (var include in includes)
                    Query = Query.Include(include);
            return Query.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T entity)
        {

            table.Add(entity);

        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
