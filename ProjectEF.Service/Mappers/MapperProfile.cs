using AutoMapper;
using ProjectEF.Domain.Entities;
using ProjectEF.Service.DTOs.EmployeeDTOs;
using ProjectEF.Service.DTOs.FeedbackDTOs;
using ProjectEF.Service.DTOs.OrderDTOs;
using ProjectEF.Service.DTOs.ProductDTOs;
using ProjectEF.Service.DTOs.RegionDTOs;
using ProjectEF.Service.DTOs.RestaurantDTOs;
using ProjectEF.Service.DTOs.UserDTOs;
using ProjectEF.Service.DTOs.VisitDTOs;

namespace ProjectEF.Service.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductForCreation>().ReverseMap();
            CreateMap<User, UserForCreation>().ReverseMap();
            CreateMap<Region, RegionForCreation>().ReverseMap();
            CreateMap<Restaurant, RestaurantForCreation>().ReverseMap();
            CreateMap<Employee, EmployeeForCreation>().ReverseMap();
            CreateMap<Feedback, FeedbackForCreation>().ReverseMap();
            CreateMap<Order, OrderForCreation>().ReverseMap();
            CreateMap<Visit, VisitForCreation>().ReverseMap();
        }
    }
}
