using System.Collections.Generic;

namespace Vue2Spa.Models
{
   public class Order
    {
        public string Id { get; set; }
        public List<Product> Items { get; set; }
        public double Total { get; set; }
    }
}
