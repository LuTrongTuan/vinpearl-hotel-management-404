using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        protected readonly ApplicationDbContext Context;

        protected GenericRepository(ApplicationDbContext context) => Context = context;

        public async Task<IList<TEntity>> GetAll() => await Context.Set<TEntity>().ToListAsync();

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
            => await Context.Set<TEntity>().FirstOrDefaultAsync(predicate);

        public Task Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
            return Task.CompletedTask;
        }

        public async Task Add(TEntity entity) => await Context.Set<TEntity>().AddAsync(entity);
    }
}