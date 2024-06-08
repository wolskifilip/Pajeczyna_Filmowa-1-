using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Data;
using Pajeczyna_Filmowa.Models;

namespace Pajeczyna_Filmowa.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            var movies = _context.Movie
                .Include(m => m.Director)
                .Include(m => m.Genre)
                .Include(m => m.MovieActors)
                .ThenInclude(ma => ma.Actor);
            return View(await movies.ToListAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .Include(m => m.Director)
                .Include(m => m.Genre)
                .Include(m => m.MovieActors)
                .ThenInclude(ma => ma.Actor)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            ViewData["DirectorId"] = new SelectList(_context.Director, "Id", "Name");
            ViewData["GenreId"] = new SelectList(_context.Genre, "Id", "Name");
            ViewData["ActorIds"] = new MultiSelectList(_context.Actor, "Id", "Name");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ImageUrl,DirectorId,GenreId,ActorIds")] MovieCreateViewModel movieVM)
        {
            if (ModelState.IsValid)
            {
                var movie = new Movie
                {
                    Title = movieVM.Title,
                    Description = movieVM.Description,
                    ImageUrl = movieVM.ImageUrl,
                    DirectorId = movieVM.DirectorId,
                    GenreId = movieVM.GenreId
                };

                _context.Add(movie);
                await _context.SaveChangesAsync();

                foreach (var actorId in movieVM.ActorIds)
                {
                    var movieActor = new MovieActor
                    {
                        MovieId = movie.Id,
                        ActorId = actorId
                    };
                    _context.MovieActor.Add(movieActor);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DirectorId"] = new SelectList(_context.Director, "Id", "Name", movieVM.DirectorId);
            ViewData["GenreId"] = new SelectList(_context.Genre, "Id", "Name", movieVM.GenreId);
            ViewData["ActorIds"] = new MultiSelectList(_context.Actor, "Id", "Name", movieVM.ActorIds);
            return View(movieVM);
        }


        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .Include(m => m.MovieActors)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var movieVM = new MovieEditViewModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                ImageUrl = movie.ImageUrl,
                DirectorId = movie.DirectorId,
                GenreId = movie.GenreId,
                ActorIds = movie.MovieActors.Select(ma => ma.ActorId).ToList()
            };

            ViewData["DirectorId"] = new SelectList(_context.Director, "Id", "Name", movieVM.DirectorId);
            ViewData["GenreId"] = new SelectList(_context.Genre, "Id", "Name", movieVM.GenreId);
            ViewData["ActorIds"] = new MultiSelectList(_context.Actor, "Id", "Name", movieVM.ActorIds);
            return View(movieVM);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,ImageUrl,DirectorId,GenreId,ActorIds")] MovieEditViewModel movieVM)
        {
            if (id != movieVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var movie = await _context.Movie
                        .Include(m => m.MovieActors)
                        .FirstOrDefaultAsync(m => m.Id == id);

                    if (movie == null)
                    {
                        return NotFound();
                    }

                    movie.Title = movieVM.Title;
                    movie.Description = movieVM.Description;
                    movie.ImageUrl = movieVM.ImageUrl;
                    movie.DirectorId = movieVM.DirectorId;
                    movie.GenreId = movieVM.GenreId;

                    _context.Update(movie);
                    await _context.SaveChangesAsync();

                    // Update movie actors
                    var existingActorIds = movie.MovieActors.Select(ma => ma.ActorId).ToList();
                    var newActorIds = movieVM.ActorIds;

                    var actorsToRemove = existingActorIds.Except(newActorIds).ToList();
                    var actorsToAdd = newActorIds.Except(existingActorIds).ToList();

                    foreach (var actorId in actorsToRemove)
                    {
                        var movieActor = movie.MovieActors.FirstOrDefault(ma => ma.ActorId == actorId);
                        if (movieActor != null)
                        {
                            _context.MovieActor.Remove(movieActor);
                        }
                    }

                    foreach (var actorId in actorsToAdd)
                    {
                        _context.MovieActor.Add(new MovieActor { MovieId = movie.Id, ActorId = actorId });
                    }

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movieVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DirectorId"] = new SelectList(_context.Director, "Id", "Name", movieVM.DirectorId);
            ViewData["GenreId"] = new SelectList(_context.Genre, "Id", "Name", movieVM.GenreId);
            ViewData["ActorIds"] = new MultiSelectList(_context.Actor, "Id", "Name", movieVM.ActorIds);
            return View(movieVM);
        }


        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .Include(m => m.Director)
                .Include(m => m.Genre)
                .Include(m => m.MovieActors)
                .ThenInclude(ma => ma.Actor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
