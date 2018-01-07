using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies() => new List<Movie>
        {
            new Movie { Id = 1, Name = "Toradora!" },
            new Movie() { Id = 2, Name = "Kimi no na wa." }
        };
    }
}