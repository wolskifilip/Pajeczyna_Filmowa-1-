using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Data;
using Pajeczyna_Filmowa.Models;

namespace Pajeczyna_Filmowa.Controllers
{
    public class MainPageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MainPageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Znajdź 5 MovieId z najwyższą średnią oceną
            var topMovieIds = await _context.Rating
                .GroupBy(r => r.MovieId)
                .OrderByDescending(g => g.Average(r => r.RatingNum))
                .Select(g => g.Key)
                .Take(5)
                .ToListAsync();

            // Znajdź filmy odpowiadające wybranym MovieId
            var topMovies = await _context.Movie
                .Where(m => topMovieIds.Contains(m.Id))
                .ToListAsync();

            return View(topMovies);
        }
    }
}
