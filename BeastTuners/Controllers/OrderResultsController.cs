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
    public class OrderResultsController : Controller
    {
        private readonly BeastTunersContext _context;

        public OrderResultsController(BeastTunersContext context)
        {
            _context = context;
        }

        // GET: OrderResults
        public async Task<IActionResult> Index()
        {
            var beastTunersContext = _context.OrderResult.Include(o => o.User);
            return View(await beastTunersContext.ToListAsync());
        }

        // GET: OrderResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderResult = await _context.OrderResult
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (orderResult == null)
            {
                return NotFound();
            }

            return View(orderResult);
        }

        // GET: OrderResults/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users.Where(u => u.UserType == "Customer"), "Id", "Email");
            return View();
        }

        // POST: OrderResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,CustomerID,OrderDate,TotalAmount,Status")] OrderResult orderResult)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(orderResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users.Where(u => u.UserType == "Customer"), "Id", "Email");
            return View(orderResult);
        }

        // GET: OrderResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderResult = await _context.OrderResult.FindAsync(id);
            if (orderResult == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users.Where(u => u.UserType == "Customer"), "Id", "Email");
            return View(orderResult);
        }

        // POST: OrderResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,CustomerID,OrderDate,TotalAmount,Status")] OrderResult orderResult)
        {
            if (id != orderResult.OrderID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderResultExists(orderResult.OrderID))
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
            ViewData["UserID"] = new SelectList(_context.Users.Where(u => u.UserType == "Customer"), "Id", "Email");
            return View(orderResult);
        }

        // GET: OrderResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderResult = await _context.OrderResult
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (orderResult == null)
            {
                return NotFound();
            }

            return View(orderResult);
        }

        // POST: OrderResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderResult = await _context.OrderResult.FindAsync(id);
            if (orderResult != null)
            {
                _context.OrderResult.Remove(orderResult);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderResultExists(int id)
        {
            return _context.OrderResult.Any(e => e.OrderID == id);
        }
    }
}
