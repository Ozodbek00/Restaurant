using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Service.DTOs.OrderDTOs
{
    public class OrderForCreation
    {
        public long ProductId { get; set; }
        public long VisitId { get; set; }
    }
}
