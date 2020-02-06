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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            try
            {
                var users = await _userService.ListAsync();
                return Ok(users);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
            
        }

        [HttpPost]
        public async Task<ActionResult> AddUsers(User user)
        {
            try
            {
                await _userService.AddAsync(user);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
            
        }
    }
}