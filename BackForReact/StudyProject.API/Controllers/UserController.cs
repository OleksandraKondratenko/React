using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyProject.BLL;
using StudyProject.Doman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUsesrService _usersService;

        public UserController(IUsesrService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<List<Users>> GetUsersAsync()
        {
            return await _usersService.GetAllUsers();
        }


        [HttpPut]
        public async Task UpdateUserAsync([FromBody]List<Users> users)
        {
            await _usersService.UpdateUser(users);
        }

        [HttpPost]
        public async Task AddUserAsync(Users users)
        {
            await _usersService.AddUser(users);
        }

    }
}
