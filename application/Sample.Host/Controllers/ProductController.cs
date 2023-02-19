using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.Core;
using Sample.Core.Services.Products;
using Serilog;
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
        [HttpGet]
        public async Task<List<ProductDto>> GetAllProduct()
        {
            _sLogger.LogInformation("Begin GetAllProduct API");
            return await _productService.GetAll();
        }
    }
}
