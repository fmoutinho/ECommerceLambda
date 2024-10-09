using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceLambda.Domain.Entities.Request
{
    public class RequestItem
    {
        public int Quantity { get; set; }
        public decimal UnitValue { get; set; }
        public Product Product {get; set; }
    }
}
