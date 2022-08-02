using System;

namespace ProjectEF.Domain.Entities
{
    public class Order : IAuditable
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long VisitId { get; set; }
        public Visit Visit { get; set; }

        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
