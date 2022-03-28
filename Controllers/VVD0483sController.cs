using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VuVanDuc2022483.Models;

namespace VuVanDuc2022483.Controllers
{
    public class VVD0483sController : Controller
    {
        private readonly MvcMovieContext _context;

        public VVD0483sController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: VVD0483s
        public async Task<IActionResult> Index()
        {
            return View(await _context.VVD0483.ToListAsync());
        }

        // GET: VVD0483s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vVD0483 = await _context.VVD0483
                .FirstOrDefaultAsync(m => m.VVDId == id);
            if (vVD0483 == null)
            {
                return NotFound();
            }

            return View(vVD0483);
        }

        // GET: VVD0483s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VVD0483s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VVDId,VVDName,VVDGender")] VVD0483 vVD0483)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vVD0483);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vVD0483);
        }

        // GET: VVD0483s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vVD0483 = await _context.VVD0483.FindAsync(id);
            if (vVD0483 == null)
            {
                return NotFound();
            }
            return View(vVD0483);
        }

        // POST: VVD0483s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VVDId,VVDName,VVDGender")] VVD0483 vVD0483)
        {
            if (id != vVD0483.VVDId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vVD0483);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VVD0483Exists(vVD0483.VVDId))
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
            return View(vVD0483);
        }

        // GET: VVD0483s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vVD0483 = await _context.VVD0483
                .FirstOrDefaultAsync(m => m.VVDId == id);
            if (vVD0483 == null)
            {
                return NotFound();
            }

            return View(vVD0483);
        }

        // POST: VVD0483s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vVD0483 = await _context.VVD0483.FindAsync(id);
            _context.VVD0483.Remove(vVD0483);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VVD0483Exists(string id)
        {
            return _context.VVD0483.Any(e => e.VVDId == id);
        }
    }
}
