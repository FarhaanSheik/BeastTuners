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
using BeastTuners.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;


namespace BeastTuners.Controllers
{
    public class OrderResultsController : Controller
    {
        private readonly BeastTunersContext _context;
        private readonly UserManager<BeastTunersUser> _userManager;
        private readonly ILogger<OrderResultsController> _logger;

        public OrderResultsController(BeastTunersContext context, UserManager<BeastTunersUser> userManager, ILogger<OrderResultsController> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }

        // GET: OrderResults
        public async Task<IActionResult> Index(
      string sortOrder,
      string currentFilter,
      string searchString,
      int pageNumber = 1,
      int pageSize = 5)
        {
            var user = await _userManager.GetUserAsync(User);
            bool isEmployee = false;

            if (user != null)
            {
                isEmployee = await _userManager.IsInRoleAsync(user, "Employee") ||
                             await _userManager.IsInRoleAsync(user, "Manager") ||
                             await _userManager.IsInRoleAsync(user, "Staff") ||
                             await _userManager.IsInRoleAsync(user, "Receptionist");
            }

            // Handle search filter
            if (!string.IsNullOrEmpty(searchString))
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;
            ViewData["DateSortParm"] = sortOrder == "OrderDate" ? "date_desc" : "OrderDate";
            ViewData["AmountSortParm"] = sortOrder == "TotalAmount" ? "amount_desc" : "TotalAmount";
            ViewData["StatusSortParm"] = sortOrder == "Status" ? "status_desc" : "Status";
            ViewData["AddressSortParm"] = sortOrder == "Address" ? "address_desc" : "Address";

            var orders = _context.OrderResult
                .Include(o => o.User)
                .AsQueryable();

            if (!isEmployee)
            {
                orders = orders.Where(o => o.UserID == user.Id);
            }

            // Apply search filter if needed
            if (!string.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(o =>
                    o.Status.Contains(searchString) ||
                    (o.User != null && o.User.Address != null && o.User.Address.Contains(searchString)));
            }

            // Sorting - with null checks for User properties
            try
            {
                orders = sortOrder switch
                {
                    "OrderDate" => orders.OrderBy(o => o.OrderDate),
                    "date_desc" => orders.OrderByDescending(o => o.OrderDate),
                    "TotalAmount" => orders.OrderBy(o => o.TotalAmount),
                    "amount_desc" => orders.OrderByDescending(o => o.TotalAmount),
                    "Status" => orders.OrderBy(o => o.Status),
                    "status_desc" => orders.OrderByDescending(o => o.Status),
                    "Address" => orders
                        .Where(o => o.User != null)
                        .OrderBy(o => o.User.Address),
                    "address_desc" => orders
                        .Where(o => o.User != null)
                        .OrderByDescending(o => o.User.Address),
                    _ => orders.OrderBy(o => o.OrderDate)
                };
            }
            catch (Exception ex)
            {
                // Log the error and fall back to default sorting
                _logger.LogError(ex, "Error applying sorting");
                orders = orders.OrderBy(o => o.OrderDate);
            }

            // Pagination
            var paginatedOrders = await PaginatedList<OrderResult>.CreateAsync(orders.AsNoTracking(), pageNumber, pageSize);
            return View(paginatedOrders);
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
