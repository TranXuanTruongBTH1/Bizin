using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bingit.Models;

namespace Bingit.Controllers
{
    public class TXTSINHVIENController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TXTSINHVIENController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TXTSINHVIEN
        public async Task<IActionResult> Index()
        {
              return _context.TXTSINHVIEN != null ? 
                          View(await _context.TXTSINHVIEN.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TXTSINHVIEN'  is null.");
        }

        // GET: TXTSINHVIEN/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TXTSINHVIEN == null)
            {
                return NotFound();
            }

            var tXTSINHVIEN = await _context.TXTSINHVIEN
                .FirstOrDefaultAsync(m => m.MASV == id);
            if (tXTSINHVIEN == null)
            {
                return NotFound();
            }

            return View(tXTSINHVIEN);
        }

        // GET: TXTSINHVIEN/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TXTSINHVIEN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MASV,NAME,MALOP")] TXTSINHVIEN tXTSINHVIEN)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tXTSINHVIEN);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tXTSINHVIEN);
        }

        // GET: TXTSINHVIEN/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TXTSINHVIEN == null)
            {
                return NotFound();
            }

            var tXTSINHVIEN = await _context.TXTSINHVIEN.FindAsync(id);
            if (tXTSINHVIEN == null)
            {
                return NotFound();
            }
            return View(tXTSINHVIEN);
        }

        // POST: TXTSINHVIEN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("MASV,NAME,MALOP")] TXTSINHVIEN tXTSINHVIEN)
        {
            if (id != tXTSINHVIEN.MASV)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tXTSINHVIEN);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TXTSINHVIENExists(tXTSINHVIEN.MASV))
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
            return View(tXTSINHVIEN);
        }

        // GET: TXTSINHVIEN/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TXTSINHVIEN == null)
            {
                return NotFound();
            }

            var tXTSINHVIEN = await _context.TXTSINHVIEN
                .FirstOrDefaultAsync(m => m.MASV == id);
            if (tXTSINHVIEN == null)
            {
                return NotFound();
            }

            return View(tXTSINHVIEN);
        }

        // POST: TXTSINHVIEN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.TXTSINHVIEN == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TXTSINHVIEN'  is null.");
            }
            var tXTSINHVIEN = await _context.TXTSINHVIEN.FindAsync(id);
            if (tXTSINHVIEN != null)
            {
                _context.TXTSINHVIEN.Remove(tXTSINHVIEN);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TXTSINHVIENExists(int? id)
        {
          return (_context.TXTSINHVIEN?.Any(e => e.MASV == id)).GetValueOrDefault();
        }
    }
}
