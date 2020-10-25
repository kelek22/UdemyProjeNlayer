using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UdemyProjeNlayer.Core.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int Id);
        Task<IEnumerable<TEntity>> GetAllAsync();


        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicae);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void remove(TEntity entity);

        void removeRange(IEnumerable<TEntity> entity);
        TEntity update(TEntity entity);

    }
}
