using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Service.Interfaces.IProductInterfaces
{
    public interface IProductInterface
    {
        IEnumerable<Product> GetAllAsync(Expression<Func<Product, bool>> predicate = null);
        Task<Product> GetAsync(Expression<Func<Product, bool>> predicate);
        Task<Product> CreateAsync(ProductForCreation item);
        Task<Product> UpdateAsync(long id, ProductForCreation item);
        Task<bool> DeleteAsync(Expression<Func<Product, bool>> predicate);
        Task SetAsDeleted(long id, Expression<Func<Product, bool>> predicate);
    }
}
