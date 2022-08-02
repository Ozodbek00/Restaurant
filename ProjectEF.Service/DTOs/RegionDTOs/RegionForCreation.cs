using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Service.DTOs.RegionDTOs
{
    public class RegionForCreation
    {
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(50)]
        public string RegionName { get; set; }
        [MaxLength(50)]
        public string District { get; set; }
        [MaxLength(50)]
        public string Street { get; set; }
        public int HomeNumber { get; set; }
    }
}
