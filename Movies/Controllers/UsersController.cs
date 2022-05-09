using BusinessLogic.Services;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Movies.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [ActionName("Get All Users")]
        public List<User> Get()
        {
            return _usersService.GetUsers();
        }

        [HttpGet("{id}")]
        [ActionName("Get User Movies")]
        public List<Movie> Get(string id)
        {
            return _usersService.GetUserMovies(id);
        }


        [HttpPost]
        [ActionName ("Create new User")]
        public User Post([FromBody] UserSession session)
        {
            return _usersService.CreateUser(session);
        }

        [HttpPost]
        [ActionName("Add User Movie")]
        public Movie Post([FromBody] Movie movie)
        {
            return _usersService.AddUserMovie(movie);
        }


    }
}
