using BeastTuners.Areas.Identity.Data;
using BeastTuners.Data;
using BeastTuners.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BeastTuners.Controllers
{
    public class PartsController : Controller
    {
        private readonly BeastTunersContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly CartService _cartService;
        private readonly UserManager<BeastTunersUser> _userManager;

        public PartsController(BeastTunersContext context, IWebHostEnvironment webHostEnvironment, CartService cartService, UserManager<BeastTunersUser> userManager)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _cartService = cartService;
            _userManager = userManager;
        }

        // GET: Parts
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
        [Authorize(Roles = "Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
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

        // GET: Parts/Edit/5
        [Authorize(Roles = "Employee")]
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
        [Authorize(Roles = "Employee")]
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

        // GET: Parts/Delete/5
        [Authorize(Roles = "Employee")]
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
        [Authorize(Roles = "Employee")]
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

        // Cart Functionality
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

        // Checkout Functionality
        [Authorize]
        public async Task<IActionResult> Checkout()
        {
            var cartItems = _cartService.GetCart();

            if (!cartItems.Any())
            {
                return RedirectToAction("Cart");
            }

            var user = await _userManager.GetUserAsync(User);

            var model = new CheckoutViewModel
            {
                FirstName = user?.FirstName,
                LastName = user?.LastName,
                Email = user?.Email,
                Phone = user?.PhoneNumber,
                Address = user?.Address,
                CartItems = cartItems,
                Subtotal = cartItems.Sum(item => item.Price * item.Quantity),
                Shipping = 15.00m,
                Tax = 0.15m
            };

            model.Tax = model.Subtotal * model.Tax;
            model.Total = model.Subtotal + model.Shipping + model.Tax;

            return View(model);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(CheckoutViewModel model)
        {
            var cartItems = _cartService.GetCart();

            if (!cartItems.Any())
            {
                return RedirectToAction("Cart");
            }

            // Recalculate totals in case of form manipulation
            model.Subtotal = cartItems.Sum(item => item.Price * item.Quantity);
            model.Shipping = 15.00m;
            model.Tax = model.Subtotal * 0.15m;
            model.Total = model.Subtotal + model.Shipping + model.Tax;
            model.CartItems = cartItems;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);

            // Create order
            var order = new OrderResult
            {
                UserID = user.Id,
                OrderDate = DateTime.Now,
                TotalAmount = model.Total,
                Status = "Processing",
                
            };

            // Add order items and update stock
            foreach (var cartItem in cartItems)
            {
                order.OrderDetails.Add(new OrderDetail
                {
                    PartID = cartItem.PartID,
                    Quantity = cartItem.Quantity,
                    UnitPrice = cartItem.Price
                });
                 
                // Update stock quantity
                var part = await _context.Part.FindAsync(cartItem.PartID);
                if (part != null)
                {
                    part.StockQuantity -= cartItem.Quantity;
                    if (part.StockQuantity < 0) part.StockQuantity = 0;
                    _context.Part.Update(part);
                }
            }

            _context.OrderResult.Add(order);

            // Clear cart
            _cartService.ClearCart();

            await _context.SaveChangesAsync();
            TempData["OrderSuccess"] = $"Order #{order.OrderID} placed successfully! This is a demo environment - no actual payment was processed.";
            return RedirectToAction("OrderConfirmation", new { id = order.OrderID });
        
        }

        [Authorize]
        public async Task<IActionResult> OrderConfirmation(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var order = await _context.OrderResult
                .Include(o => o.OrderDetails)
                .ThenInclude(oi => oi.Part)
                .FirstOrDefaultAsync(o => o.OrderID == id && o.UserID == user.Id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // Order History
        [Authorize]
        public async Task<IActionResult> OrderHistory()
        {
            var user = await _userManager.GetUserAsync(User);
            var orders = await _context.OrderResult
                .Where(o => o.UserID == user.Id)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            return View(orders);
        }

        [Authorize]
        public async Task<IActionResult> OrderDetails(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var order = await _context.OrderResult
                .Include(o => o.OrderDetails)
                .ThenInclude(oi => oi.Part)
                .FirstOrDefaultAsync(o => o.OrderID == id && o.UserID == user.Id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}