using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Domain.Entities;

namespace ProjectEF.Data.Repositories
{
    public class VisitRepository : GenericRepository<Visit>, IVisitRepository
    {
        public VisitRepository(ForEF_DbContext dbContext) : base(dbContext)
        {
        }
    }
}
