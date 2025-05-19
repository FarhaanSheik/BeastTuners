using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeastTuners.Data;
using BeastTuners.Models;
using Microsoft.AspNetCore.Authorization;


namespace BeastTuners.Controllers
{
    
    public class PartSuppliersController : Controller
    {
        private readonly BeastTunersContext _context;

        public PartSuppliersController(BeastTunersContext context)
        {
            _context = context;
        }

        // GET: PartSuppliers
        public async Task<IActionResult> Index()
        {
            var beastTunersContext = _context.PartSupplier.Include(p => p.Part).Include(p => p.Supplier);
            return View(await beastTunersContext.ToListAsync());
        }

        // GET: PartSuppliers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partSupplier = await _context.PartSupplier
                .Include(p => p.Part)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.PartSuppliersID == id);
            if (partSupplier == null)
            {
                return NotFound();
            }

            return View(partSupplier);
        }

        // GET: PartSuppliers/Create
        public IActionResult Create()
        {
            ViewData["PartID"] = new SelectList(_context.Part, "PartID", "PartName");
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "SupplierID", "SupplierName");
            return View();
        }

        // POST: PartSuppliers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartSuppliersID,PartID,SupplierID")] PartSupplier partSupplier)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(partSupplier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PartID"] = new SelectList(_context.Part, "PartID", "PartName", partSupplier.PartID);
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "SupplierID", "SupplierName", partSupplier.SupplierID);
            return View(partSupplier);
        }

        // GET: PartSuppliers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partSupplier = await _context.PartSupplier.FindAsync(id);
            if (partSupplier == null)
            {
                return NotFound();
            }
            ViewData["PartID"] = new SelectList(_context.Part, "PartID", "PartName", partSupplier.PartID);
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "SupplierID", "SupplierName", partSupplier.SupplierID);
            return View(partSupplier);
        }

        // POST: PartSuppliers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PartSuppliersID,PartID,SupplierID")] PartSupplier partSupplier)
        {
            if (id != partSupplier.PartSuppliersID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(partSupplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartSupplierExists(partSupplier.PartSuppliersID))
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
            ViewData["PartID"] = new SelectList(_context.Part, "PartID", "PartName", partSupplier.PartID);
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "SupplierID", "SupplierName", partSupplier.SupplierID);
            return View(partSupplier);
        }

        // GET: PartSuppliers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partSupplier = await _context.PartSupplier
                .Include(p => p.Part)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.PartSuppliersID == id);
            if (partSupplier == null)
            {
                return NotFound();
            }

            return View(partSupplier);
        }

        // POST: PartSuppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partSupplier = await _context.PartSupplier.FindAsync(id);
            if (partSupplier != null)
            {
                _context.PartSupplier.Remove(partSupplier);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartSupplierExists(int id)
        {
            return _context.PartSupplier.Any(e => e.PartSuppliersID == id);
        }
    }
}
