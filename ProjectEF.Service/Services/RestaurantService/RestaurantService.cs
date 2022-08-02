using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.RestaurantDTOs;
using ProjectEF.Service.Interfaces.RestaurantInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Service.Services.RestaurantService
{
    public class RestaurantService: IRestaurantInterface
    {
        private readonly ForEF_DbContext dbContexts;
        private readonly IRestaurantRepository restaurantRepo;

        public RestaurantService()
        {
            dbContexts = new ForEF_DbContext();
            restaurantRepo = new RestaurantRepository(dbContexts);
        }
        public async Task<Restaurant> CreateAsync(RestaurantForCreation item)
        {
            var entity = await restaurantRepo.GetAsync(u => u.Name == item.Name);

            if (entity != null)
            {
                throw new Exception("User with this name exists!");
            }

            entity = new Restaurant
            {
                Name = item.Name,
                CreatedAt = DateTime.Now, 
                Description = item.Description,
                FoodType = item.FoodType,
                RegionId = item.RegionId
            };

            var ent = await restaurantRepo.CreateAsync(entity);
            await restaurantRepo.SaveAsync();

            return ent;
        }

        public async Task<bool> DeleteAsync(Expression<Func<Restaurant, bool>> predicate)
            => await restaurantRepo.DeleteAsync(predicate);


        public async Task<IEnumerable<Restaurant>> GetAllAsync(Expression<Func<Restaurant, bool>> predicate = null)
        {
            var lis = restaurantRepo.GetAll(predicate);

            return lis.ToList();
        }

        public async Task<Restaurant> GetAsync(Expression<Func<Restaurant, bool>> predicate)
        {
            var entity = await restaurantRepo.GetAsync(predicate);

            if (entity == null)
            {
                throw new Exception("There is no restaurant with this name!");
            }

            return entity;
        }


        public async Task<Restaurant> UpdateAsync(long id, RestaurantForUpdate item)
        {
            var rest = await restaurantRepo.GetAsync(p => p.Id == id);

            if (rest == null)
            {
                throw new Exception("There is no restaurant with this ID!");
            }

            rest.Name = item.Name;
            rest.UpdatedAt = item.UpdatedAt;
            rest.Description = item.Description;
            rest.FoodType = item.FoodType;
            rest.RegionId = item.RegionId;

            var model = restaurantRepo.Update(rest);
            await restaurantRepo.SaveAsync();

            return model;
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
