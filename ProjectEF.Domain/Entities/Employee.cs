using ProjectEF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Domain.Entities
{
    public class Employee : IAuditable
    {
        public long RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public Position Position { get; set; }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Visit> Visits { get; set; }
    }
}
