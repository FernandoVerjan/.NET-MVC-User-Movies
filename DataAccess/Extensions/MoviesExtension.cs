namespace DataAccess.Extensions
{
    public static class MoviesExtensions
    {
        public static BusinessLogic.DomainModels.Movies ToDomainModel(this Models.Movie m)
        {
            return new BusinessLogic.DomainModels.Movies
            {
                UserId = m.UserId,
                Id = m.Id,
                Name = m.Name,
                Genre= m.Genre
            };
        }
    }
}