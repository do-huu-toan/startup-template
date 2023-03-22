using Sample.Infratructure;
using Sample.Infratructure.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }
        public List<ProductDto> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
