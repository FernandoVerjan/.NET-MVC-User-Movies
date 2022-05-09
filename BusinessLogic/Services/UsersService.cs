using BusinessLogic.Extensions;
using BusinessLogic.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Services
{
    public class UsersService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UsersService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public List<User> GetUsers()
        {
            return _repositoryManager.Users.GetAll().Select(x => new User()
            {
                Email = x.Email,
                Name = x.Name,
                UserId = x.UserId
            }).ToList();

        }



        public List<DTO.Movie> GetUserMovies(string id)
        {
            return _repositoryManager.Movies.GetUserMovies(id).Select(x => new Movie()
            {
                UserId = x.UserId,
                Id = x.Id,
                Name = x.Name,
                Genre = x.Genre
            }).ToList();
        }

        public Movie AddUserMovie(DTO.Movie movie)
        {
            var domainMovies = new DomainModels.Movies()
            {
                UserId = movie.UserId,
                Id = movie.Id,
                Name = movie.Name,
                Genre = movie.Genre
            };

            var dbUser = _repositoryManager.Movies.AddUserMovie(domainMovies);
            _repositoryManager.Save();

            return dbUser.ToDTO();
        }

        public User CreateUser(UserSession user)
        {

            // DONE Valida que no exista

            var domainUser = new DomainModels.User()
            {
                Email = user.Email,
                Name = user.Name,
                Password = user.Password
            };


        if ( _repositoryManager.Users.UserExists(domainUser))
            {
                throw new Exception("User already exists, choose a differente Email");
            }
            else
            {
                var dbUser = _repositoryManager.Users.Add(domainUser);
                _repositoryManager.Save();

                return dbUser.ToDTO();
            }



        }

    }
}
