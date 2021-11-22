using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        protected readonly ApplicationDbContext Context;

        protected GenericRepository(ApplicationDbContext context) => Context = context;

        public virtual async Task<IList<TEntity>> GetAll() => await Context.Set<TEntity>().ToListAsync();
        public virtual async Task<IList<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>()
                .Where(predicate)
                .ToListAsync();
        }

        public virtual async Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
            => await Context.Set<TEntity>().FirstOrDefaultAsync(predicate);

        public virtual Task Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
            return Task.CompletedTask;
        }

        public virtual async Task Add(TEntity entity) => await Context.Set<TEntity>().AddAsync(entity);
    }
}