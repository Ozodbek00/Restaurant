using ProjectEF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Domain.Entities
{
    public class Feedback : IAuditable
    {
        public string Content { get; set; } = string.Empty;
        public FeedbackType Type { get; set; }
        public FeedbackScore Score { get; set; }

        public long Id { get ; set ; }
        public DateTime CreatedAt { get ; set ; }
        public DateTime? UpdatedAt { get ; set ; }
    }
}
