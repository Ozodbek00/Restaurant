using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Domain.Entities;

namespace ProjectEF.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ForEF_DbContext dbContext) : base(dbContext)
        {
        }
    }
}
