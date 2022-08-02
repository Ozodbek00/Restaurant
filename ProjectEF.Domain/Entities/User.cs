using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ProjectEF.Domain.Entities
{
    public class User : IAuditable
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}