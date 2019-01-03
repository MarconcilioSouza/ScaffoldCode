using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ScaffoldCode.Domain.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        void Remove(TEntity obj);
        void Dispose();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
