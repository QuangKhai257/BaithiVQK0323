using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaithiVQK0323.Models;
using MvcMovie.Data;

namespace BaithiVQK0323.Controllers
{
    public class VQKcau3Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public VQKcau3Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: VQKcau3
        public async Task<IActionResult> Index()
        {
              return _context.VQKcau3 != null ? 
                          View(await _context.VQKcau3.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.VQKcau3'  is null.");
        }

        // GET: VQKcau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.VQKcau3 == null)
            {
                return NotFound();
            }

            var vQKcau3 = await _context.VQKcau3
                .FirstOrDefaultAsync(m => m.hoten == id);
            if (vQKcau3 == null)
            {
                return NotFound();
            }

            return View(vQKcau3);
        }

        // GET: VQKcau3/Create
        public IActionResult Create()
        {
            return View();
        }
        

        // POST: VQKcau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("hoten,gioitinh,diachi")] VQKcau3 vQKcau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vQKcau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vQKcau3);
        }

        // GET: VQKcau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.VQKcau3 == null)
            {
                return NotFound();
            }

            var vQKcau3 = await _context.VQKcau3.FindAsync(id);
            if (vQKcau3 == null)
            {
                return NotFound();
            }
            return View(vQKcau3);
        }

        // POST: VQKcau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("hoten,gioitinh,diachi")] VQKcau3 vQKcau3)
        {
            if (id != vQKcau3.hoten)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vQKcau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VQKcau3Exists(vQKcau3.hoten))
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
            return View(vQKcau3);
        }

        // GET: VQKcau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.VQKcau3 == null)
            {
                return NotFound();
            }

            var vQKcau3 = await _context.VQKcau3
                .FirstOrDefaultAsync(m => m.hoten == id);
            if (vQKcau3 == null)
            {
                return NotFound();
            }

            return View(vQKcau3);
        }

        // POST: VQKcau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.VQKcau3 == null)
            {
                return Problem("Entity set 'MvcMovieContext.VQKcau3'  is null.");
            }
            var vQKcau3 = await _context.VQKcau3.FindAsync(id);
            if (vQKcau3 != null)
            {
                _context.VQKcau3.Remove(vQKcau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VQKcau3Exists(string id)
        {
          return (_context.VQKcau3?.Any(e => e.hoten == id)).GetValueOrDefault();
        }
    }
}
