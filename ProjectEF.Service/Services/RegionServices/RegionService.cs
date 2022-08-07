using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.RegionDTOs;
using ProjectEF.Service.Interfaces.RegionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Service.Services.RegionServices
{
    public class RegionService : IRegionInterface
    {
        private readonly ForEF_DbContext dbContexts;
        private readonly IRegionRepository regionRepo;

        public RegionService()
        {
            dbContexts = new ForEF_DbContext();
            regionRepo = new RegionRepository(dbContexts);
        }
        public async Task<Region> CreateAsync(RegionForCreation item)
        {
            var entity = await regionRepo.GetAsync(u => u.Street == item.Street && u.HomeNumber == item.HomeNumber);

            if (entity != null)
            {
                throw new Exception("Region with this name exists!");
            }

            entity = new Region
            {
                Country = item.Country,
                RegionName = item.RegionName,
                District = item.District,
                Street = item.Street,
                HomeNumber = item.HomeNumber
            };

            var ent = await regionRepo.CreateAsync(entity);
            await regionRepo.SaveAsync();

            return ent;
        }

        public async Task<bool> DeleteAsync(Expression<Func<Region, bool>> predicate)
            => await regionRepo.DeleteAsync(predicate);


        public async Task<IEnumerable<Region>> GetAllAsync(Expression<Func<Region, bool>> predicate = null)
        {
            var lis = regionRepo.GetAll(predicate);

            return lis.ToList();
        }

        public async Task<Region> GetAsync(Expression<Func<Region, bool>> predicate)
        {
            var entity = await regionRepo.GetAsync(predicate);

            if (entity == null)
            {
                throw new Exception("There is no region with this name!");
            }

            return entity;
        }


        public async Task<Region> UpdateAsync(long id, RegionForCreation item)
        {
            var rest = await regionRepo.GetAsync(p => p.Id == id);

            if (rest == null)
            {
                throw new Exception("There is no region with this ID!");
            }

            rest.Country = item.Country;
            rest.RegionName = item.RegionName;
            rest.District = item.District;
            rest.Street = item.Street;
            rest.HomeNumber = item.HomeNumber;

            var model = regionRepo.Update(rest);
            await regionRepo.SaveAsync();

            return model;
        }
    }
}
