namespace BusinessLogic.Extensions
{
    public static class UserExtensions
    {
        public static DTO.User ToDTO(this DomainModels.User u)
        {
            return new DTO.User()
            {
                Email = u.Email,
                Name = u.Name,
                UserId = u.UserId
            };
        }
    }
}
