using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Domain.Entities;

namespace ProjectEF.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ForEF_DbContext dbContext) : base(dbContext)
        {
        }
    }
}
