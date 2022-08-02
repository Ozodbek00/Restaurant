using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectEF.Domain.Entities
{
    public interface IAuditable
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
