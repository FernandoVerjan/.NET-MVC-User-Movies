using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IMoviesRepository
    {
        public List<DomainModels.Movies> GetAll(); 

        public DomainModels.Movies Add(DomainModels.Movies movies);

        public DomainModels.Movies AddUserMovie(DomainModels.Movies movies);

        public List<DomainModels.Movies> GetUserMovies(string id);
    }
}
