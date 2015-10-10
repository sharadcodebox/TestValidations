using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestValidations.Models;

namespace TestValidations.Repository
{
    public interface IIMDBRepository : IDisposable
    {
        IEnumerable<IMDB> GetMovies();
        IMDB GetMovieByID(int MovieID);
        void AddMovie(IMDB movie);
        void DeleteMovie(int MovieID);
        void UpdateMovie(IMDB movie);
        void Save();
    }
}
