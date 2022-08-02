using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.RestaurantDTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Service.Interfaces.RestaurantInterfaces
{
    public interface IRestaurantInterface
    {
        Task<IEnumerable<Restaurant>> GetAllAsync(Expression<Func<Restaurant, bool>> predicate = null);
        Task<Restaurant> GetAsync(Expression<Func<Restaurant, bool>> predicate);
        Task<Restaurant> CreateAsync(RestaurantForCreation item);
        Task<Restaurant> UpdateAsync(long id, RestaurantForUpdate item);
        Task<bool> DeleteAsync(Expression<Func<Restaurant, bool>> predicate);
        Task SaveAsync();
    }
}
