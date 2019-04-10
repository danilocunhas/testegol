using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Teste.GOL.Domain.Repository;
using Teste.GOL.Infra.Persistence.ORM.DataContexts;


namespace Teste.GOL.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TesteGOLContext _context;

        public Repository(TesteGOLContext context)
        {
            _context = context;
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetFirst(Expression<Func<T, bool>> filter)
        {
           return _context.Set<T>().Where(filter).FirstOrDefault();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}