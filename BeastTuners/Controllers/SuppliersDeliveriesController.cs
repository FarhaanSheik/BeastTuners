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
    public class SuppliersDeliveriesController : Controller
    {
        private readonly BeastTunersContext _context;

        public SuppliersDeliveriesController(BeastTunersContext context)
        {
            _context = context;
        }

        // GET: SuppliersDeliveries
        public async Task<IActionResult> Index()
        {
            var beastTunersContext = _context.SuppliersDelivery.Include(s => s.Part).Include(s => s.Supplier);
            return View(await beastTunersContext.ToListAsync());
        }

        // GET: SuppliersDeliveries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliersDelivery = await _context.SuppliersDelivery
                .Include(s => s.Part)
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierDeliveryID == id);
            if (suppliersDelivery == null)
            {
                return NotFound();
            }

            return View(suppliersDelivery);
        }

        // GET: SuppliersDeliveries/Create
        public IActionResult Create()
        {
            ViewData["PartID"] = new SelectList(_context.Part, "PartID", "Category");
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "SupplierID", "Address");
            return View();
        }

        // POST: SuppliersDeliveries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierDeliveryID,SupplierID,PartID,DeliveryTime")] SuppliersDelivery suppliersDelivery)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(suppliersDelivery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PartID"] = new SelectList(_context.Part, "PartID", "Category", suppliersDelivery.PartID);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "SupplierID", "Address", suppliersDelivery.SupplierID);
            return View(suppliersDelivery);
        }

        // GET: SuppliersDeliveries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliersDelivery = await _context.SuppliersDelivery.FindAsync(id);
            if (suppliersDelivery == null)
            {
                return NotFound();
            }
            ViewData["PartID"] = new SelectList(_context.Part, "PartID", "Category", suppliersDelivery.PartID);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "SupplierID", "Address", suppliersDelivery.SupplierID);
            return View(suppliersDelivery);
        }

        // POST: SuppliersDeliveries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierDeliveryID,SupplierID,PartID,DeliveryTime")] SuppliersDelivery suppliersDelivery)
        {
            if (id != suppliersDelivery.SupplierDeliveryID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(suppliersDelivery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuppliersDeliveryExists(suppliersDelivery.SupplierDeliveryID))
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
            ViewData["PartID"] = new SelectList(_context.Part, "PartID", "Category", suppliersDelivery.PartID);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "SupplierID", "Address", suppliersDelivery.SupplierID);
            return View(suppliersDelivery);
        }

        // GET: SuppliersDeliveries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliersDelivery = await _context.SuppliersDelivery
                .Include(s => s.Part)
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierDeliveryID == id);
            if (suppliersDelivery == null)
            {
                return NotFound();
            }

            return View(suppliersDelivery);
        }

        // POST: SuppliersDeliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suppliersDelivery = await _context.SuppliersDelivery.FindAsync(id);
            if (suppliersDelivery != null)
            {
                _context.SuppliersDelivery.Remove(suppliersDelivery);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuppliersDeliveryExists(int id)
        {
            return _context.SuppliersDelivery.Any(e => e.SupplierDeliveryID == id);
        }
    }
}
