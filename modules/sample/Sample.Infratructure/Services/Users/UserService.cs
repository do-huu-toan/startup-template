using AutoMapper;
using Sample.Core;
using Sample.Core.Repositories;
using Sample.Core.Users;
using Sample.Entity.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infratructure.Services
{
    public class UserService : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<int> Create(UserDto userDto)
        {
            return await _userRepository.Create(userDto);
        }
    }
}
