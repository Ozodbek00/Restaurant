using ProjectEF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Data.IRepositories
{
    public interface IUserRepository: IGenericRepository<User>
    {
    }
}
