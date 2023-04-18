using Sample.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Application.IRepositories
{
    public interface IProductRepository
    {
        Task<List<ProductDto>> GetAllAsync();
        List<ProductDto> GetAll();
    }
}
