using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Models;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Order> List()
        {
            return Enumerable.Range(1, 10).Select(index => new Order
            {
                Id = "Order no " + index,
                Items = new List<Product>(),
                Total = 10.5 + index
            });
        }

        [HttpGet("[action]")]
        public Order Show(string id)
        {
            return new Order();
        }

        [HttpPut("[action]")]
        public bool Update(Order order)
        {
            return false;
        }

        [HttpPost("[action]")]
        public bool Create(Order order)
        {
            return false;
        }

    }
}