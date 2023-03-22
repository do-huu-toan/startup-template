using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.Application.Services;
using Sample.Infratructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _sLogger;
        public ProductController(IProductService productService, ILogger<ProductController> sLogger)
        {
            _productService = productService;
            _sLogger = sLogger;
        }
        [HttpGet("async")]
        public async Task<List<ProductDto>> GetAllProductAsync()
        {
            _sLogger.LogInformation("Begin GetAllProduct API");
            return await _productService.GetAllAsync();
        }

        [HttpGet]
        public List<ProductDto> GetAllProduct()
        {
            _sLogger.LogInformation("Begin GetAllProduct API");
            return _productService.GetAll();
        }
    }
}
