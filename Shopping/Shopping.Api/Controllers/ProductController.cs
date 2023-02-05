using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.Api.Data;
using Shopping.Api.Models;

namespace Shopping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ProductContext _context;

        public ProductController(ProductContext context, ILogger<WeatherForecastController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.Find(prop => true).ToListAsync();
        }
    }
}
