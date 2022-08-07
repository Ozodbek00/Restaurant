using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.RegionDTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Service.Interfaces.RegionInterfaces
{
    public interface IRegionInterface
    {
        Task<IEnumerable<Region>> GetAllAsync(Expression<Func<Region, bool>> predicate = null);
        Task<Region> GetAsync(Expression<Func<Region, bool>> predicate);
        Task<Region> CreateAsync(RegionForCreation item);
        Task<Region> UpdateAsync(long id, RegionForCreation item);
        Task<bool> DeleteAsync(Expression<Func<Region, bool>> predicate);
    }
}
