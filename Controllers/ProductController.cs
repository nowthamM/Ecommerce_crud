using Ecommerce.Db;
using Ecommerce.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _productDbContext;
        private readonly ILogger<ProductController> _logger;
        public ProductController(ProductDbContext productDbContext, ILogger<ProductController> logger)
        {
            _productDbContext = productDbContext;
            _logger = logger;
        }
        [HttpPost]
        [Route("CreateProduct")]
        public IActionResult Create(Products products)
        {
            _productDbContext.Add(products);
            _productDbContext.SaveChanges();
            _logger.LogInformation("Added a product in products table");
            return Ok(products);
        }
        [HttpGet]
        [Route("GetProduct")]
        public IActionResult GetProduct()
        {
            List<Products> products = new List<Products>();
            products = _productDbContext.products.ToList();
            return Ok(products);
        }
        [HttpGet]
        [Route("CustomizedQuery")]
        public IActionResult CustomQuery(string query)
        {
            var result = _productDbContext.products.FromSqlRaw(query).ToList();
            return Ok(result);
        }
    }
}
