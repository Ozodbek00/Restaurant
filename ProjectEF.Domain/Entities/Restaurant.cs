using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectEF.Domain.Enums;

namespace ProjectEF.Domain.Entities
{
    public class Restaurant : IAuditable
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public long RegionId { get; set; }
        public Region Region { get; set; }
        public FoodType FoodType { get; set; }

        public long Id { get ; set ; }
        public DateTime CreatedAt { get ; set ; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set ; }
        public ICollection<Employee> Employees { get; set; }
    }
}
