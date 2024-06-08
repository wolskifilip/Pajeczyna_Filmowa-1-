using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Data;
using Pajeczyna_Filmowa.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Pajeczyna_Filmowa.Controllers
{
    public class MovieReviewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                id = 1;
            }

            // Fetch the first review for the given MovieId
            var firstReview = await _context.Review
                .Include(r => r.Movie) // Include the movie details if necessary
                .Include(r => r.User)  // Include the user details if necessary
                .Where(r => r.MovieId == id)
                .FirstOrDefaultAsync();

            if (firstReview == null)
            {
                return NotFound("No review found for this movie.");
            }

            return View(firstReview);
        }
    }
}
