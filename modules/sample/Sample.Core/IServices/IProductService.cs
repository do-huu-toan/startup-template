using Sample.Application.Dtos;
using Sample.Infratructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Application.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllAsync();
        List<ProductDto> GetAll();
        
    }
}
