using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestValidations.Repository;
using TestValidations.Models;

namespace TestValidations.Controllers
{
    public class HomeController : Controller
    {

        private IIMDBRepository DbRepository;
        // without unity
        //public HomeController()
        //{
        //    this.DbRepository = new IMDBRepository(new IMDBContext()); // without unity
        //}

        // for unity container

        public HomeController(IIMDBRepository db)
        {
            this.DbRepository = db;
        }

        public ActionResult MovieIndex()
        {
            var movieData = DbRepository.GetMovies();

            return View(movieData);
        }

        [HttpGet]
        public ActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMovie(IMDB movie)
        {
            if (ModelState.IsValid)
            {
                DbRepository.AddMovie(movie);
                DbRepository.Save();
            }
            return RedirectToAction("MovieIndex");
        }

        public ActionResult DeleteMovie(int id)
        {
            this.DbRepository.DeleteMovie(id);
            DbRepository.Save();
            return RedirectToAction("MovieIndex");
        }

        [HttpGet]
        public ActionResult UpdateMovie(int id)
        {
            return View(this.DbRepository.GetMovieByID(id));
        }

        [HttpPost]
        public ActionResult UpdateMovie(IMDB movie)
        {
            this.DbRepository.UpdateMovie(movie);
            DbRepository.Save();
            return RedirectToAction("MovieIndex");
        }

    }
}