namespace BusinessLogic.Extensions
{
    public static class MoviesExtensions
    {
        public static DTO.Movie ToDTO(this DomainModels.Movies m)
        {
            return new DTO.Movie()
            {
                UserId = m.UserId,
                Id = m.Id,
                Name = m.Name,
                Genre = m.Genre
            };
        }
    }
}
