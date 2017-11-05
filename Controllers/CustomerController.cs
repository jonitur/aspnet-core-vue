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
                Name = "Customer " + index,
                Address = "Address " + index,
                Total = index
            });
        }
    }
}