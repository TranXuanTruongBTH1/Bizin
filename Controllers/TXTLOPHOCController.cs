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
    public class TXTLOPHOCController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TXTLOPHOCController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TXTLOPHOC
        public async Task<IActionResult> Index()
        {
              return _context.TXTLOPHOC != null ? 
                          View(await _context.TXTLOPHOC.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TXTLOPHOC'  is null.");
        }

        // GET: TXTLOPHOC/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TXTLOPHOC == null)
            {
                return NotFound();
            }

            var tXTLOPHOC = await _context.TXTLOPHOC
                .FirstOrDefaultAsync(m => m.MALOPHOC == id);
            if (tXTLOPHOC == null)
            {
                return NotFound();
            }

            return View(tXTLOPHOC);
        }

        // GET: TXTLOPHOC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TXTLOPHOC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MALOPHOC,TENLOPHOC")] TXTLOPHOC tXTLOPHOC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tXTLOPHOC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tXTLOPHOC);
        }

        // GET: TXTLOPHOC/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TXTLOPHOC == null)
            {
                return NotFound();
            }

            var tXTLOPHOC = await _context.TXTLOPHOC.FindAsync(id);
            if (tXTLOPHOC == null)
            {
                return NotFound();
            }
            return View(tXTLOPHOC);
        }

        // POST: TXTLOPHOC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MALOPHOC,TENLOPHOC")] TXTLOPHOC tXTLOPHOC)
        {
            if (id != tXTLOPHOC.MALOPHOC)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tXTLOPHOC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TXTLOPHOCExists(tXTLOPHOC.MALOPHOC))
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
            return View(tXTLOPHOC);
        }

        // GET: TXTLOPHOC/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TXTLOPHOC == null)
            {
                return NotFound();
            }

            var tXTLOPHOC = await _context.TXTLOPHOC
                .FirstOrDefaultAsync(m => m.MALOPHOC == id);
            if (tXTLOPHOC == null)
            {
                return NotFound();
            }

            return View(tXTLOPHOC);
        }

        // POST: TXTLOPHOC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.TXTLOPHOC == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TXTLOPHOC'  is null.");
            }
            var tXTLOPHOC = await _context.TXTLOPHOC.FindAsync(id);
            if (tXTLOPHOC != null)
            {
                _context.TXTLOPHOC.Remove(tXTLOPHOC);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TXTLOPHOCExists(string id)
        {
          return (_context.TXTLOPHOC?.Any(e => e.MALOPHOC == id)).GetValueOrDefault();
        }
    }
}
