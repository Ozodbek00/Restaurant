using System;
using System.Threading.Tasks;

namespace ProjectEF.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        IRegionRepository Regions { get; }
        IRestaurantRepository Restaurants { get; }
        IUserRepository Users { get; }
        IVisitRepository Visits { get; }
        Task SaveChangesAsync();
    }
}
