using BusinessLogic.Services;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesService _moviesService;

        public MoviesController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public List<Movie> Get()
        {
            return _moviesService.GetMovies();
        }

        //[HttpPost]
        //public Movie Post([FromBody]Movie movie)
        //{
        //    return _moviesService.CreateMovie(movie);
        //}
    }
}