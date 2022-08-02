using ProjectEF.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Data.IRepositories
{
    public interface IGenericRepository<TSource> where TSource : class
    {
        IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> predicate = null);
        Task<TSource> GetAsync(Expression<Func<TSource, bool>> predicate);
        Task<TSource> CreateAsync(TSource item);
        TSource Update(TSource item);
        Task<bool> DeleteAsync(Expression<Func<TSource, bool>> predicate);
        Task SaveAsync();
    }
}
