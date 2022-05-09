using BusinessLogic.DomainModels;
using BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Extensions;

namespace DataAccess.Repositories
{
    public class MoviesRepository : RepositoryBase<Models.Movie>, IMoviesRepository
    {
        public MoviesRepository(MoviesContext context) : base(context) { }

        public Movies Add(Movies movies)
        {
            var moviesModel = new Models.Movie()
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = movies.Name,
                Genre = movies.Genre
                
            };
            Create(moviesModel);

            return moviesModel.ToDomainModel();
        }

        public Movies AddUserMovie(Movies movie)
        {
            var moviesModel = new Models.Movie()
            {
                UserId = movie.UserId,
                Id = System.Guid.NewGuid().ToString(),
                Name = movie.Name,
                Genre = movie.Genre

            };
            Create(moviesModel);

            return moviesModel.ToDomainModel();
        }

        public List<Movies> GetAll()
        {
            var movies = FindAll(false).ToList();

            var moviesDomain = movies.Select(x => x.ToDomainModel());
            return moviesDomain.ToList();
        }

        public List<Movies> GetUserMovies(string id)
        {
            var movies = FindAll(false).ToList();

            var moviesModel = movies.FindAll(x => x.UserId == id).Select(x => x.ToDomainModel()).ToList();


            return moviesModel;
        }

        
    }
}
