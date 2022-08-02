using System;
using System.Collections.Generic;

namespace ProjectEF.Domain.Entities
{
    public class Visit : IAuditable
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public long FeedbackId { get; set; }
        public Feedback Feedback { get; set; }


        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
