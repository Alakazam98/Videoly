using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoly.Models;
using System.Data.Entity;
using Videoly.ViewModel;
using Videoly.Interfaces;

namespace Videoly.Controllers
{
    [Authorize]
    public class MoviesController : Controller, IMovies
    {
        // GET: Movies
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult MoviesForm(int id)
        {
            var movies = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movies == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel()
            {
                Movie = movies,
                Genres = _context.Genres.ToList()
            };

            return View("MoviesForm", viewModel);
        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var moviesInDb = _context.Movies.SingleOrDefault(c => c.Id == movie.Id);


                moviesInDb.Name = movie.Name;
                moviesInDb.GenreId = movie.GenreId;
                moviesInDb.ReleaseDate = movie.ReleaseDate;
                moviesInDb.DateAdded = movie.DateAdded;
                moviesInDb.NumberInStock = movie.NumberInStock;


            }
            _context.SaveChanges();

            return RedirectToAction("Movies", "Movies");
        }
        public ActionResult Movies()
        {
            var movie = _context.Movies.Include(m=> m.Genre).ToList();
            return View(movie);
        }

        public ActionResult New(Movie movie)
        {
            return View("New");
        }
      


    }
}