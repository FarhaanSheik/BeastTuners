using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeastTuners.Data;
using BeastTuners.Models;

namespace BeastTuners.Controllers
{
    public class PartsController : Controller
    {
        private readonly BeastTunersContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly CartService _cartService;

        public PartsController(BeastTunersContext context, IWebHostEnvironment webHostEnvironment, CartService cartService)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _cartService = cartService;
        }

        public async Task<IActionResult> Index(string searchString, string categoryFilter)
        {
            var parts = _context.Part.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                parts = parts.Where(p => p.PartName.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(categoryFilter))
            {
                parts = parts.Where(p => p.Category == categoryFilter);
            }

            return View(await parts.ToListAsync());
        }

        // GET: Parts/Category/{category}
        public async Task<IActionResult> Category(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return NotFound();
            }

            var parts = await _context.Part
                .Where(p => p.Category == category)
                .ToListAsync();

            if (!parts.Any())
            {
                return NotFound($"No parts found in category: {category}");
            }

            ViewData["Category"] = category;
            return View(parts);
        }

        // GET: Parts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var part = await _context.Part
                .FirstOrDefaultAsync(m => m.PartID == id);
            if (part == null)
            {
                return NotFound();
            }

            return View(part);
        }

        // GET: Parts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartID,PartName,Category,Price,StockQuantity,Description")] Part part, IFormFile ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile != null && ImageFile.Length > 0)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + ImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(fileStream);
                    }

                    part.ImagePath = "/images/" + uniqueFileName; // Store relative path
                }

                _context.Add(part);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(part);
        }

        // GET: Parts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var part = await _context.Part.FindAsync(id);
            if (part == null)
            {
                return NotFound();
            }
            return View(part);
        }

        // POST: Parts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PartID,PartName,Category,Price,StockQuantity,Description,ImagePath")] Part part, IFormFile ImageFile)
        {
            if (id != part.PartID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Check if new image is uploaded
                    if (ImageFile != null && ImageFile.Length > 0)
                    {
                        string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + ImageFile.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await ImageFile.CopyToAsync(fileStream);
                        }

                        part.ImagePath = "/images/" + uniqueFileName; // Save new image path
                    }

                    _context.Update(part);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartExists(part.PartID))
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
            return View(part);
        }

        // GET: Parts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var part = await _context.Part
                .FirstOrDefaultAsync(m => m.PartID == id);
            if (part == null)
            {
                return NotFound();
            }

            return View(part);
        }

        // POST: Parts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var part = await _context.Part.FindAsync(id);
            if (part != null)
            {
                _context.Part.Remove(part);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartExists(int id)
        {
            return _context.Part.Any(e => e.PartID == id);
        }

        // CART FUNCTIONALITY 

        public IActionResult AddToCart(int id, string returnUrl)
        {
            var part = _context.Part.Find(id);
            if (part == null) return NotFound();

            var cartItem = new CartItem
            {
                PartID = part.PartID,
                PartName = part.PartName,
                Price = part.Price,
                Quantity = 1,
                ImagePath = part.ImagePath
            };

            _cartService.AddToCart(cartItem);

       
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index"); // Default: Go back to Parts Table if no returnUrl is provided
        }

        public IActionResult Cart()
        {
            var cartItems = _cartService.GetCart();
            return View(cartItems);
        }

        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id);
            return RedirectToAction("Cart");
        }

        public IActionResult ClearCart()
        {
            _cartService.ClearCart();
            return RedirectToAction("Cart");
        }

    }
}