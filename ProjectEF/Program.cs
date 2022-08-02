using Microsoft.EntityFrameworkCore;
using ProjectEF.Data.DbContexts;
using ProjectEF.Data.IRepositories;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Entities;
using ProjectEF.Domain.Enums;
using ProjectEF.Service.DTOs.RegionDTOs;
using ProjectEF.Service.DTOs.RestaurantDTOs;
using ProjectEF.Service.DTOs.UserDTOs;
using ProjectEF.Service.Interfaces.RegionInterfaces;
using ProjectEF.Service.Interfaces.RestaurantInterfaces;
using ProjectEF.Service.Interfaces.UserInterfaces;
using ProjectEF.Service.Services.RegionServices;
using ProjectEF.Service.Services.RestaurantService;
using ProjectEF.Service.Services.UserService;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectEF.Service.Interfaces.IProductInterfaces;
using ProjectEF.Service.Services.ProductServices;
using ProjectEF.Service.DTOs.ProductDTOs;

namespace ProjectEF
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ForEF_DbContext dbContext = new ForEF_DbContext();

            IProductInterface productServ = new ProductService();
            //var prod = await productServ.GetAsync(pro => pro.Id == 3);

            //await productServ.UpdateAsync(3, new ProductForCreation { Description = "Watermelon of uzb", Name = "Watermelon", Price = 24000 });
            //await productServ.CreateAsync(new ProductForCreation { Name = "Watermelon", Price = 35000, Description = "Watermelons of Mirzachul"});

            //await productServ.DeleteAsync(p => p.Id == 2);

            foreach(var i in productServ.GetAllAsync())
                Console.WriteLine(i.Name+" "+ i.CreatedAt);


            //IUnitOfWork unitOfWork = new UnitOfWork(dbContext);

            //unitOfWork.Restaurants.Update(new Restaurant() 
            //{
                
            //});

        }
    }
}
