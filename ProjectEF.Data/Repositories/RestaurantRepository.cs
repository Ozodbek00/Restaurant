using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Domain.Entities;

namespace ProjectEF.Data.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(ForEF_DbContext dbContext) : base(dbContext)
        {
        }
    }
}
