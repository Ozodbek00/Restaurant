using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.EmployeeDTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Service.Interfaces.IEmployeeInterfaces
{
    public interface IEmployeeInterface
    {
        Task<Employee> CreateAsync(EmployeeForCreation entity);
        Task<Employee> UpdateAsync(long id, EmployeeForCreation entity);
        Task<Employee> GetAsync(Expression<Func<Employee, bool>> expression);
        IEnumerable<Employee> GetAll(Expression<Func<Employee, bool>> expression = null);
        Task<Employee> DeleteAsync(Expression<Func<Employee, bool>> expression);
    }
}
