using BusinessLogic.Extensions;
using BusinessLogic.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Services
{
    public class MoviesService
    {

        private readonly IRepositoryManager _repositoryManager;

        public MoviesService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public List<Movie> GetMovies()
        {
            return _repositoryManager.Movies.GetAll().Select(x => new Movie()
            {
                Id = x.Id,
                Name = x.Name,
                Genre = x.Genre
            }).ToList();

        }
    }
}
