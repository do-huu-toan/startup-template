using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Repositories
{
    public interface IProductRepository
    {
        public Task<List<ProductDto>> GetAll();
    }
}
