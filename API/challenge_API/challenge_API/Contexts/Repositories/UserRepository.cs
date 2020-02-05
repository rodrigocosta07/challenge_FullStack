using challenge_API.Contexts;
using challenge_API.Contexts.Repositories;
using challenge_API.Domain.Models;
using challenge_API.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_API.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(DbAppContext context) : base(context)
        { }
        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _context.User.ToListAsync();
        }
        public async Task AddAsync(User user)
        {
            await _context.User.AddAsync(user);
        }
    }
}
