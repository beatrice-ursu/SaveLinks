using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SaveLinks.DataLayer.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entityToDelete);
        void Delete(object id);
        void Delete(Func<TEntity, bool> where);
        bool Exists(object primaryKey);
        IEnumerable<TEntity> Get();
        TEntity Get(Func<TEntity, bool> where);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        Task<TEntity> GetByIdAsync(object id);
        TEntity GetFirst(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> GetMany(Func<TEntity, bool> where);
        IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where);
        TEntity GetSingle(Func<TEntity, bool> predicate);
        IQueryable<TEntity> GetWithInclude(Expression<Func<TEntity, bool>> predicate, params string[] include);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}