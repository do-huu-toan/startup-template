using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infratructure.Repositories
{
    public interface IProductRepository
    {
        Task<List<ProductDto>> GetAllAsync();
        List<ProductDto> GetAll();
    }
}
