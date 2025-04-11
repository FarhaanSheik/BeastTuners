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

        public IActionResult Create()
        {
            return View();
        }

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

                    part.ImagePath = "/images/" + uniqueFileName;
                }

                _context.Add(part);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(part);
        }

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
                    if (ImageFile != null && ImageFile.Length > 0)
                    {
                        string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + ImageFile.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await ImageFile.CopyToAsync(fileStream);
                        }

                        part.ImagePath = "/images/" + uniqueFileName;
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

        // Updated AddToCart Method
        [HttpPost]
        public IActionResult AddToCart(int id, int quantity = 1, string returnUrl = null)
        {
            var part = _context.Part.Find(id);
            if (part == null) return NotFound();

            var cartItem = new CartItem
            {
                PartID = part.PartID,
                PartName = part.PartName,
                Price = part.Price,
                Quantity = quantity,  
                ImagePath = part.ImagePath
            };

            _cartService.AddToCart(cartItem);

            TempData["CartMessage"] = $"{part.PartName} (x{quantity}) added to cart!";

            return !string.IsNullOrEmpty(returnUrl) ? Redirect(returnUrl) : Redirect(Request.Headers["Referer"].ToString());
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

        [HttpPost]
        public IActionResult UpdateCart(int id, int quantity)
        {
            if (quantity < 1)
            {
                _cartService.RemoveFromCart(id);
            }
            else
            {
                _cartService.UpdateCart(id, quantity);
            }

            return RedirectToAction("Cart");
        }
    }
}
