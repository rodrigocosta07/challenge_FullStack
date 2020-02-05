using challenge_API.Domain.Models;
using challenge_API.Domain.Repositories;
using challenge_API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _userRepository.ListAsync();
        }

        public async Task AddAsync(User user)
        {
            await _userRepository.AddAsync(user);
        }
    }
}
