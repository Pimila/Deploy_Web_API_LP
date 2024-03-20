using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Deploy_Web_API_LP.Models; 
using Deploy_Web_API_LP.Data; 
using System.Net;

namespace Deploy_Web_API_LP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YourEntitiesController : ControllerBase
    {
        private readonly YourDbContext _context;

        public YourEntitiesController(YourDbContext context)
        {
            _context = context;
        }

        // Этот метод возвращает все записи из таблицы Customer
        [HttpGet("customers")]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            var customers = _context.Customers.ToList();
            return Ok(customers);
        }

        // Этот метод возвращает все записи из таблицы Address
        [HttpGet("addresses")]
        public ActionResult<IEnumerable<Address>> GetAllAddresses()
        {
            var addresses = _context.Addresses.ToList();
            return Ok(addresses);
        }

        // Этот метод возвращает все записи из таблицы Product
        [HttpGet("products")]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
    }
}
