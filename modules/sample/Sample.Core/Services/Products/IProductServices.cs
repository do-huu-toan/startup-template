using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Services.Products
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAll();
    }
}
