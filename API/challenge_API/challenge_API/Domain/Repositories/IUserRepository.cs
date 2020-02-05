﻿using challenge_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_API.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListAsync();

        Task AddAsync(User user);
    }
}
