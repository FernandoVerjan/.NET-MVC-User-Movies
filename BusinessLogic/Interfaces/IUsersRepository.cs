using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IUsersRepository
    {
        public List<DomainModels.User> GetAll();

        public DomainModels.User Add(DomainModels.User user);

        public bool UserExists(DomainModels.User user);
    }
}
