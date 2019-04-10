using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Teste.GOL.Domain.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entity);
        List<TEntity> GetAll();
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter);
        TEntity GetFirst(Expression<Func<TEntity, bool>> filter);
        void Insert(TEntity entity);
        void Update(TEntity entity);
    }
}
