using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using challenge_API.Domain.Models;
using challenge_API.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace challenge_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _userService.ListAsync();
            return users;
        }

        [HttpPost]
        public async Task AddUsers(User user)
        {
            await _userService.AddAsync(user);
        }
    }
}