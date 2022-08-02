using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Domain.Entities;

namespace ProjectEF.Data.Repositories
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(ForEF_DbContext dbContext) : base(dbContext)
        {
        }
    }
}
