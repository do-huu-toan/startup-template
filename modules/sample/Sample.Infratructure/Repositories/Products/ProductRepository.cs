using Microsoft.EntityFrameworkCore;
using Sample.Core;
using Sample.Core.Repositories;
using Sample.Entity;
using Sample.Entity.Entities.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Infratructure.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly SampleDbContext _context;

        public ProductRepository(SampleDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            var result = new List<ProductDto>();
            foreach(var product in products)
            {
                var productDto = new ProductDto
                {
                    Name = product.Name,
                };
                result.Add(productDto);
            }
            return result;
        }
    }
}
