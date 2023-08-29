using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DbFirstEFTutorial.Models;

namespace DbFirstEFTutorial.Controllers
{
    public class TvShowsController : Controller
    {
        private readonly DbFirstEFTutorialContext _context;

        public TvShowsController(DbFirstEFTutorialContext context)
        {
            _context = context;
        }

        // GET: TvShows
        public async Task<IActionResult> Index()
        {
            return _context.TvShows != null ?
                        View(await _context.TvShows.ToListAsync()) :
                        Problem("Entity set 'DbFirstEFTutorialContext.TvShows'  is null.");
        }

        // GET: TvShows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TvShows == null)
            {
                return NotFound();
            }

            var tvShow = await _context.TvShows
                .FirstOrDefaultAsync(m => m.ShowId == id);
            if (tvShow == null)
            {
                return NotFound();
            }

            return View(tvShow);
        }

        // GET: TvShows/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TvShows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShowId,Name,Chapters")] TvShow tvShow)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tvShow);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tvShow);
        }

        // GET: TvShows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TvShows == null)
            {
                return NotFound();
            }

            var tvShow = await _context.TvShows.FindAsync(id);
            if (tvShow == null)
            {
                return NotFound();
            }
            return View(tvShow);
        }

        // POST: TvShows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShowId,Name,Chapters")] TvShow tvShow)
        {
            if (id != tvShow.ShowId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tvShow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TvShowExists(tvShow.ShowId))
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
            return View(tvShow);
        }

        // GET: TvShows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TvShows == null)
            {
                return NotFound();
            }

            var tvShow = await _context.TvShows
                .FirstOrDefaultAsync(m => m.ShowId == id);
            if (tvShow == null)
            {
                return NotFound();
            }

            return View(tvShow);
        }

        // POST: TvShows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TvShows == null)
            {
                return Problem("Entity set 'DbFirstEFTutorialContext.TvShows'  is null.");
            }
            var tvShow = await _context.TvShows.FindAsync(id);
            if (tvShow != null)
            {
                _context.TvShows.Remove(tvShow);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TvShowExists(int id)
        {
            return (_context.TvShows?.Any(e => e.ShowId == id)).GetValueOrDefault();
        }
    }
}
