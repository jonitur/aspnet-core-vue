using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Models;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Customer> List()
        {
            return Enumerable.Range(1, 10).Select(index => new Customer
            {
                Id = index.ToString(),
                Name = "Customer " + index,
                Address = "Address " + index,
                Total = index
            });
        }

        [HttpGet("[action]")]
        public Customer Show(string id)
        {
            return new Customer
            {
                Name = "Customer " + id,
                Address = "Address " + id,
                Total = 10
            };
        }

        [HttpPut("[action]")]
        public bool Update(Customer customer)
        {
            return false;
        }

        [HttpPost("[action]")]
        public bool Create(Customer customer)
        {
            return false;
        }
        
    }
}