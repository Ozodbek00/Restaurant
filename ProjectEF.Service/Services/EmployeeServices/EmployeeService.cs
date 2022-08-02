using AutoMapper;
using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.EmployeeDTOs;
using ProjectEF.Service.Interfaces.IEmployeeInterfaces;
using ProjectEF.Service.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Service.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeInterface
    {
        private readonly ForEF_DbContext dbContext;
        private readonly IEmployeeRepository employeeRepo;
        private readonly IMapper mapper;

        public EmployeeService()
        {
            dbContext = new ForEF_DbContext();
            employeeRepo = new EmployeeRepository(dbContext);
            mapper = new MapperConfiguration(c =>
            {
                c.AddProfile<MapperProfile>();
            }).CreateMapper();
        }

        public async Task<Employee> CreateAsync(EmployeeForCreation entity)
        {
            var emp = employeeRepo.GetAsync(p => p.FullName == entity.FullName);

            if(emp is not null)
            {
                throw new Exception("There is an Employee with the same name, so it can't register");
            }

            var model = await mapper.Map(entity, emp);
            model.CreatedAt = DateTime.Now;

            model = await employeeRepo.CreateAsync(model);

            await employeeRepo.SaveAsync();

            return model;
        }

        public Task<Employee> DeleteAsync(Expression<Func<Employee, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll(Expression<Func<Employee, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetAsync(Expression<Func<Employee, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateAsync(long id, EmployeeForCreation entity)
        {
            throw new NotImplementedException();
        }
    }
}
