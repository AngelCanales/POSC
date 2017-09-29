using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public interface IRepository<TEntity>
       where TEntity : class
    {
 
            IQueryable<TEntity> GetAll();
            IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

            void Add(TEntity entity);
            void Edit(TEntity entity);
            void Save();




        IQueryable<TEntity> All();

        TEntity Create();

        TEntity Create(TEntity entity);

        TEntity Delete(TEntity entity);

        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);

        TEntity Find(params object[] keys);

        Task<TEntity> FindAsync(params object[] keys);

        Task<TEntity> FindAsync(CancellationToken token, params object[] keys);


        TEntity First(Expression<Func<TEntity, bool>> predicate);


        Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate);


        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);


        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        int SaveChanges();

        Task<int> SaveChangesAsync();

        IQueryable<TResult> Transform<TResult>(Expression<Func<TEntity, TResult>> predicate);

        TEntity Update(TEntity entity);

        TEntity Update(TEntity oldEntity, TEntity newEntity);

    }
    
}

