using System.Diagnostics;
using BeastTuners.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeastTuners.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public async Task<IActionResult> Subscribe(string email)
        {
            if (!string.IsNullOrEmpty(email) && email.Contains("@"))
            {
                // Here you would typically save to database or send to email service
                TempData["SubscriptionSuccess"] = "Thank you for subscribing to our newsletter!";
            }
            else
            {
                TempData["SubscriptionError"] = "Please enter a valid email address.";
            }

            return RedirectToAction("Index");
        }
    }
}
