using ProjectEF.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Service.DTOs.ProductDTOs
{
    public class ProductForCreation
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
