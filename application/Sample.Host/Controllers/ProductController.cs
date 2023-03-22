using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.Application.Services;
using Sample.Host.ViewModels.Response;
using Sample.Infratructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _sLogger;
        public ProductController(IProductService productService, ILogger<ProductController> sLogger)
        {
            _productService = productService;
            _sLogger = sLogger;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            _sLogger.LogInformation("Begin GetAllProduct API");
            var result = await _productService.GetAllAsync();
            return Ok(new ResponseApi(result, true));
        }
    }
}
