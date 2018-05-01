using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kidding.Models;

namespace Kidding.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovieViewModels();
            
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = GetMovieViewModels();
            var movie = movies.FirstOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
          

        }

        public List<MovieViewModel> GetMovieViewModels()
        {
            var movies = new List<MovieViewModel>
            {
                new MovieViewModel(){Name = "Movie 1", Id=1},
                new MovieViewModel(){Name = "Movie 2", Id=2}
            };
            return movies;
        }
    }
}