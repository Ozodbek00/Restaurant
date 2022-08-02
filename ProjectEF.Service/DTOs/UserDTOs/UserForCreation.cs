using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Service.DTOs.UserDTOs
{
    public class UserForCreation
    {
        [MaxLength(50), Required]
        public string Name { get; set; }
    }
}
