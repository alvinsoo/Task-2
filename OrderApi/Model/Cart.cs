using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public double ProductPrice { get; set; }
        public double Total { get; set; }
        public string OrderStatus { get; set; }
        public int OrderId { get; set; }
    }
}
