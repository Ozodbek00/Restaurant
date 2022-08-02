using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Service.Interfaces.UserInterfaces
{
    public interface UserInterface
    {
        Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> predicate = null);
        Task<User> GetAsync(Expression<Func<User, bool>> predicate);
        Task<User> CreateAsync(UserForCreation item);
        Task<User> UpdateAsync(long id, UserForUpdate item);
        Task<bool> DeleteAsync(Expression<Func<User, bool>> predicate);
        Task SaveAsync();
    }
}
