using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Service.DTOs.UserDTOs
{
    public class UserForUpdate
    {
        [MaxLength(50), Required]
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
