using ProjectEF.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Service.DTOs.EmployeeDTOs
{
    public class EmployeeForCreation
    {
        public long RestaurantId { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public Position Position { get; set; }
    }
}
