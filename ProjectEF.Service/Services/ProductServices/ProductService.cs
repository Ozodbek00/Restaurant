using AutoMapper;
using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Entities;
using ProjectEF.Domain.Enums;
using ProjectEF.Service.DTOs.ProductDTOs;
using ProjectEF.Service.Interfaces.IProductInterfaces;
using ProjectEF.Service.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectEF.Service.Services.ProductServices
{
    public class ProductService : IProductInterface
    {
        private readonly ForEF_DbContext dbContext;
        private readonly IProductRepository productRepo;
        private readonly IMapper mapper;

        public ProductService()
        {
            dbContext = new ForEF_DbContext();
            productRepo = new ProductRepository(dbContext);
            mapper = new MapperConfiguration(c =>
            {
                c.AddProfile<MapperProfile>();
            }).CreateMapper();
        }
        public async Task<Product> CreateAsync(ProductForCreation item)
        {
            var entity = await productRepo.GetAsync(p => p.Name == item.Name);

            if (entity is not null)
            {
                throw new Exception("Product with this name and price exists");
            }

            var model = mapper.Map(item, entity);

            model.ProductState = ProductState.Created;
            model.CreatedAt = DateTime.Now;

            var res = await productRepo.CreateAsync(model);

            await productRepo.SaveAsync();

            return res;
        }

        public async Task<bool> DeleteAsync(Expression<Func<Product, bool>> predicate)
        {
            bool prod = await productRepo.DeleteAsync(predicate);

            await productRepo.SaveAsync();

            return prod;
        }

        public IEnumerable<Product> GetAllAsync(Expression<Func<Product, bool>> predicate = null)
        {
            var lis = productRepo.GetAll(predicate);

            return lis.ToList();
        }

        public async Task<Product> GetAsync(Expression<Func<Product, bool>> predicate)
        {
            return await productRepo.GetAsync(predicate);
        }

        public async Task SetAsDeleted(long id, Expression<Func<Product, bool>> predicate)
        {
            var prod = await productRepo.GetAsync(predicate);

            if (prod == null)
            {
                throw new Exception("Unable to delete");
            }

            prod.ProductState = ProductState.NotAvailable;
            await productRepo.SaveAsync();
        }

        public async Task<Product> UpdateAsync(long id, ProductForCreation item)
        {
            var entity = await productRepo.GetAsync(p => p.Id == id);

            if (entity is null)
            {
                throw new Exception("There is no such product to be updated");
            }

            Product product = mapper.Map(item, entity);

            product.UpdatedAt = DateTime.Now;
            product.ProductState = ProductState.Updated;

            productRepo.Update(product);
            await productRepo.SaveAsync();

            return product;
        }
    }
}
