using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ForEF_DbContext dbContext;
        
        public IEmployeeRepository Employees { get; }

        public IOrderRepository Orders { get; }

        public IProductRepository Products { get; }

        public IRegionRepository Regions { get; }

        public IRestaurantRepository Restaurants { get; }

        public IUserRepository Users { get; }

        public IVisitRepository Visits { get; }



        public UnitOfWork(ForEF_DbContext dbContextt)
        {
            this.dbContext = dbContextt;

            Employees = new EmployeeRepository(dbContext);
            Orders = new OrderRepository(dbContext);
            Products = new ProductRepository(dbContext);
            Regions = new RegionRepository(dbContext);
            Restaurants = new RestaurantRepository(dbContext);
            Users = new UserRepository(dbContext);
            Visits = new VisitRepository(dbContext);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
