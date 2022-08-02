using Microsoft.EntityFrameworkCore;
using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Data.Repositories
{
    public class GenericRepository<TSource> : IGenericRepository<TSource> where TSource : class
    {
        protected readonly ForEF_DbContext dbContexts;
        protected readonly DbSet<TSource> dbset;
        public GenericRepository(ForEF_DbContext dbContext)
        {
            dbContexts = dbContext;
            dbset = dbContext.Set<TSource>();
        }

        public async Task<TSource> CreateAsync(TSource item)
            => (await dbset.AddAsync(item)).Entity;

        public async Task<bool> DeleteAsync(Expression<Func<TSource, bool>> predicate)
        {
            var entity = await dbset.FirstOrDefaultAsync(predicate);
            
            if (entity is null)
                return false;

            dbset.Remove(entity);

            return true;
        }

        public IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> predicate = null)
            => predicate is null ? dbset : dbset.Where(predicate);


        public Task<TSource> GetAsync(Expression<Func<TSource, bool>> predicate)
            => dbset.FirstOrDefaultAsync(predicate);


        public TSource Update(TSource item)
            => dbset.Update(item).Entity;


        public async Task SaveAsync()
        {
            await dbContexts.SaveChangesAsync();
        }
    }
}
