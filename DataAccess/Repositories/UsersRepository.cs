using BusinessLogic.DomainModels;
using BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Extensions;

namespace DataAccess.Repositories
{
    public class UsersRepository : RepositoryBase<Models.User>, IUsersRepository
    {
        public UsersRepository(MoviesContext context) : base(context) { }

        public User Add(User user)
        {
            var userModel = new Models.User()
            {
                UserId = System.Guid.NewGuid().ToString(),
                Email = user.Email,
                Name = user.Name,
                Password = user.Password
            };
            Create(userModel);

            return userModel.ToDomainModel();
        }

        public List<User> GetAll()
        {
            var users = FindAll(false).ToList();

            var usersDomain = users.Select(x => x.ToDomainModel()); 
            return usersDomain.ToList();
        }

        public bool UserExists(User user)
        {
            var users = FindAll(false).ToList();

            var usersDomain = users.Exists(x => x.Email == user.Email);

            return usersDomain;
        }
    }
}
