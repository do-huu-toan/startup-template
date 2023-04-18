using Microsoft.EntityFrameworkCore;
using Sample.Entity;
using Sample.Entity.Entities.Users;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Sample.Application.IRepositories;
using Sample.Application.Dtos;

namespace Sample.Infratructure.Repositories
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
