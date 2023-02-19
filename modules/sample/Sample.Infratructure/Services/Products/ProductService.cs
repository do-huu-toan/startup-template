using Sample.Core;
using Sample.Core.Repositories;
using Sample.Core.Services.Products;
using Sample.Entity.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infratructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<ProductDto>> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
