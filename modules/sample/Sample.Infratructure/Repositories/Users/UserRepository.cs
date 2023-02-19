using Microsoft.EntityFrameworkCore;
using Sample.Core;
using Sample.Core.Repositories;
using Sample.Entity;
using Sample.Entity.Entities.Users;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Sample.Infratructure.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly SampleDbContext _context;

        public UserRepository(SampleDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(UserDto user)
        {
            var newUser = new User
            {
                Id = Guid.NewGuid(), 
                Username = user.Name,
                Password = user.Password,
                CreatedDate = System.DateTime.Now
            };
            _context.Add(newUser);
            return await _context.SaveChangesAsync();
        }
    }
}
