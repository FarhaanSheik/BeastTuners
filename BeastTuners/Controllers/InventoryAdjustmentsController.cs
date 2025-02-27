using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeastTuners.Data;
using BeastTuners.Models;

namespace BeastTuners.Controllers
{
    public class InventoryAdjustmentsController : Controller
    {
        private readonly BeastTunersContext _context;

        public InventoryAdjustmentsController(BeastTunersContext context)
        {
            _context = context;
        }

        // GET: InventoryAdjustments
        public async Task<IActionResult> Index()
        {
            var beastTunersContext = _context.InventoryAdjustment.Include(i => i.Part);
            return View(await beastTunersContext.ToListAsync());
        }

        // GET: InventoryAdjustments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryAdjustment = await _context.InventoryAdjustment
                .Include(i => i.Part)
                .FirstOrDefaultAsync(m => m.AdjustmentID == id);
            if (inventoryAdjustment == null)
            {
                return NotFound();
            }

            return View(inventoryAdjustment);
        }

        // GET: InventoryAdjustments/Create
        public IActionResult Create()
        {
            ViewData["PartID"] = new SelectList(_context.Set<Part>(), "PartID", "Category");
            return View();
        }

        // POST: InventoryAdjustments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdjustmentID,PartID,AdjustmentType,Quantity,AdjustmentDate,Reason")] InventoryAdjustment inventoryAdjustment)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(inventoryAdjustment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PartID"] = new SelectList(_context.Set<Part>(), "PartID", "Category", inventoryAdjustment.PartID);
            return View(inventoryAdjustment);
        }

        // GET: InventoryAdjustments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryAdjustment = await _context.InventoryAdjustment.FindAsync(id);
            if (inventoryAdjustment == null)
            {
                return NotFound();
            }
            ViewData["PartID"] = new SelectList(_context.Set<Part>(), "PartID", "Category", inventoryAdjustment.PartID);
            return View(inventoryAdjustment);
        }

        // POST: InventoryAdjustments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdjustmentID,PartID,AdjustmentType,Quantity,AdjustmentDate,Reason")] InventoryAdjustment inventoryAdjustment)
        {
            if (id != inventoryAdjustment.AdjustmentID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventoryAdjustment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryAdjustmentExists(inventoryAdjustment.AdjustmentID))
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
            ViewData["PartID"] = new SelectList(_context.Set<Part>(), "PartID", "Category", inventoryAdjustment.PartID);
            return View(inventoryAdjustment);
        }

        // GET: InventoryAdjustments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryAdjustment = await _context.InventoryAdjustment
                .Include(i => i.Part)
                .FirstOrDefaultAsync(m => m.AdjustmentID == id);
            if (inventoryAdjustment == null)
            {
                return NotFound();
            }

            return View(inventoryAdjustment);
        }

        // POST: InventoryAdjustments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventoryAdjustment = await _context.InventoryAdjustment.FindAsync(id);
            if (inventoryAdjustment != null)
            {
                _context.InventoryAdjustment.Remove(inventoryAdjustment);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoryAdjustmentExists(int id)
        {
            return _context.InventoryAdjustment.Any(e => e.AdjustmentID == id);
        }
    }
}
