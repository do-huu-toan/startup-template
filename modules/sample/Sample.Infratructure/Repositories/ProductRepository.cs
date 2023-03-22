using Microsoft.EntityFrameworkCore;
using Sample.Entity;
using Sample.Entity.Entities.Users;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Infratructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SampleDbContext _context;

        public ProductRepository(SampleDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            var result = new List<ProductDto>();
            foreach (var product in products)
            {
                var productDto = new ProductDto
                {
                    Name = product.Name,
                };
                result.Add(productDto);
            }
            return result;
        }

        public List<ProductDto> GetAll()
        {
            var products = _context.Products.ToList();
            var result = new List<ProductDto>();
            foreach (var product in products)
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
