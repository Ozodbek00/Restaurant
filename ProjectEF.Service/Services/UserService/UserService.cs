using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.UserDTOs;
using ProjectEF.Service.Interfaces.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Service.Services.UserService
{
    public class UserService : UserInterface
    {
        private readonly ForEF_DbContext dbContexts;
        private readonly IUserRepository userRepo;

        public UserService()
        {
            dbContexts = new ForEF_DbContext();
            userRepo = new UserRepository(dbContexts);
        }
        public async Task<User> CreateAsync(UserForCreation item)
        {
            var entity = await userRepo.GetAsync(u => u.Name == item.Name);

            if (entity != null)
            {
                throw new Exception("User with this name exists!");
            }

            entity = new User
            {
                Name = item.Name,
                CreatedAt = DateTime.Now
            };

            var ent = await userRepo.CreateAsync(entity);
            await userRepo.SaveAsync();

            return ent;
        }

        public async Task<bool> DeleteAsync(Expression<Func<User, bool>> predicate)
            => await userRepo.DeleteAsync(predicate);


        public async Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> predicate = null)
            => userRepo.GetAll(predicate);
        

        public async Task<User> GetAsync(Expression<Func<User, bool>> predicate)
        {
            var entity = await userRepo.GetAsync(predicate);

            if (entity == null)
            {
                throw new Exception("There is no user with this name!");
            }

            return entity;
        }


        public async Task<User> UpdateAsync(long id, UserForUpdate item)
        {
            var useer = await userRepo.GetAsync(p => p.Id == id);

            if (useer == null)
            {
                throw new Exception("There is no user with this ID!");
            }

            useer.Name = item.Name;
            useer.UpdatedAt = item.UpdatedAt;

            var model = userRepo.Update(useer);
            await userRepo.SaveAsync();

            return model;
        }
    }
}
