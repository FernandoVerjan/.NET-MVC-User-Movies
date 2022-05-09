namespace DataAccess.Extensions
{
    public static class UserExtensions
    {
        public static BusinessLogic.DomainModels.User ToDomainModel(this Models.User u)
        {
            return new BusinessLogic.DomainModels.User
            {
                UserId = u.UserId,
                Name = u.Name,
                Password = u.Password,
                Email = u.Email
            };
        }
    }
}
