using Sample.Infratructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Application.Services
{
    public interface IUserService
    {
        Task<int> Create(UserDto userDto);
    }
}
