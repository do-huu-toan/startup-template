using Sample.Application.Services;
using Sample.Infratructure.Repositories;
using System.Threading.Tasks;

namespace Sample.Infratructure.Services
{
    public class UserService : IUserService
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
