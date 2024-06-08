using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Data;
using Pajeczyna_Filmowa.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pajeczyna_Filmowa.Controllers
{
    public class RandomMovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RandomMovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RandomMovie()
        {
            var movieCount = await _context.Movie.CountAsync();
            if (movieCount == 0)
            {
                return NotFound("No movies found.");
            }

            var random = new Random();
            var randomIndex = random.Next(0, movieCount);

            var randomMovie = await _context.Movie.Skip(randomIndex)
                                                  .FirstOrDefaultAsync();

            if (randomMovie == null)
            {
                return NotFound("No movie found.");
            }

            return View("RandomMovie", randomMovie);
        }
    }
}
