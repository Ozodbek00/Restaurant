using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Domain.Entities
{
    public class Region
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(50)]
        public string Country { get; set; } = string.Empty;
        [MaxLength(50)]
        public string RegionName { get; set; } = string.Empty;
        [MaxLength(50)]
        public string District { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Street { get; set; } = string.Empty;
        public int HomeNumber { get; set; }
    }
}
