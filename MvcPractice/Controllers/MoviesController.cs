using MvcPractice.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace MvcPractice.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        #region Actions

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c =>c.Genre).ToList();
            return View(movies);
        }

        //GET: Movie by id
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c =>c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        #endregion

        #region Private helpers

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id = 1, Name = "Terminator"},
                new Movie{Id = 2, Name = "Robocop"},
                new Movie{Id = 3, Name = "Rambo"}
            };
        }

        #endregion

        #region Some examples


        // GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie() {Name = "Shrek" };
        //    var customers = new List<Customer>()
        //    {
        //        new Customer {Name = "Customer1"},
        //        new Customer {Name = "Customer2"}
        //    };
        //
        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };
        //
        //    return View(viewModel);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //
        //    return Content(String
        //        .Format("Page index= {0}& sortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/release/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, byte month)
        //{
        //    return Content(year + "/" + month);
        //}

        #endregion
    }
}