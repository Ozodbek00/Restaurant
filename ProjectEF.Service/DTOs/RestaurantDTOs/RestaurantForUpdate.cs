using ProjectEF.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Service.DTOs.RestaurantDTOs
{
    public class RestaurantForUpdate
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public long RegionId { get; set; }
        public FoodType FoodType { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
