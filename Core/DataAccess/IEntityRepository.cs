using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    //generic constraint
    //when we write T:class, we mean that T must be a reference type (so not only a class).
    //IEntity: may be IEntity or an object implementing IEntity.
    //new(): so T cannot be IEntity

    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
