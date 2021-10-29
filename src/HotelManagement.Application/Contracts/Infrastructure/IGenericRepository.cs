using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelManagement.Application.Contracts.Infrastructure
{
    public interface IGenericRepository<TEntity>
        where TEntity : class
    {
        Task<IList<TEntity>> GetAll();
        Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        Task Update(TEntity entity);
        Task Add(TEntity entity);
    }
}