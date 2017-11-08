using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Models;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Product> List()
        {
            return new List<Product>();
        }

        [HttpGet("[action]")]
        public Product Show(string id)
        {
            return new Product();
        }

        [HttpPut("[action]")]
        public bool Update(Product product)
        {
            return false;
        }

        [HttpPost("[action]")]
        public bool Create(Product product)
        {
            return false;
        }

    }
}