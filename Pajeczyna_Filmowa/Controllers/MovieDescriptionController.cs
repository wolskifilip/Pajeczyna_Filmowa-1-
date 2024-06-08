using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Data;
using System.Linq;

namespace Pajeczyna_Filmowa.Controllers
{
    public class MovieDescriptionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieDescriptionController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                id = 1;
            }

            var movie = _context.Movie
                .Include(m => m.Director)
                .Include(m => m.Genre)
                .Include(m => m.MovieActors)
                .ThenInclude(ma => ma.Actor)
                .FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var ratings = _context.Rating.Where(r => r.MovieId == id).Select(r => r.RatingNum);
            double averageRating = ratings.Any() ? ratings.Average() : 0;
            ViewData["AverageRating"] = averageRating;

            return View(movie);
        }
    }
}
