using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestValidations.Models;

namespace TestValidations.Repository
{
    public class IMDBRepository : IIMDBRepository
    {
        private IMDBContext _imdbContext;

        public IMDBRepository(IMDBContext Context)
        {
            this._imdbContext = Context;
        }

        public IEnumerable<IMDB> GetMovies()
        {
            return _imdbContext.IMDBs.ToList();
        }

        public IMDB GetMovieByID(int MovieID)
        {
            return _imdbContext.IMDBs.FirstOrDefault(m => m.Id == MovieID);
        }

        public void AddMovie(IMDB movie)
        {
            _imdbContext.IMDBs.Add(movie);
        }

        public void DeleteMovie(int MovieID)
        {
             IMDB movie = _imdbContext.IMDBs.Find(MovieID);
            _imdbContext.IMDBs.Remove(movie);
        }

        public void UpdateMovie(IMDB movie)
        {
            _imdbContext.Entry(movie).State = System.Data.Entity.EntityState.Modified;
        }

        public void Save()
        {
            _imdbContext.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _imdbContext.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



    }
}