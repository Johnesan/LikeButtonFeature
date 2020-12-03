using LikeButtonFeature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LikeButtonFeature.Data.Repositories
{
    public interface IBaseRepository<TEntity, PK> where TEntity : BaseEntity<PK>
    {
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        Task<TEntity> Get(object id);
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(object id);
        Task Delete(TEntity entity);
    }
}
