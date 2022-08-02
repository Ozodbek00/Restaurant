using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Service.DTOs.VisitDTOs
{
    public class VisitForCreation
    {
        public long UserId { get; set; }
        public long EmployeeId { get; set; }
        public long FeedbackId { get; set; }
    }
}
