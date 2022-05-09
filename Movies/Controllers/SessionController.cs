using BusinessLogic.Services;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly UsersService _userService;

        public SessionController(UsersService usersService)
        {
            _userService = usersService;
        }

        //[HttpPost]
        //public object Post([FromBody] UserLogin login)
        //{
        //    return _userService.Login(login);
        //}
    }
}
