using BusinessLogic.DomainModels;
using BusinessLogic.Interfaces;
using System.Collections.Generic;

namespace DataAccessMongo
{
    public class MongoUsersRepository : IUsersRepository
    {
        List<User> IUsersRepository.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
