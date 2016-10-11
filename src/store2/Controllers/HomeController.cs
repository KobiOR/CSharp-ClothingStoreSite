using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using store2.Models;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity;
using System.IO;
using Microsoft.AspNet.Routing;

namespace store2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var applicationDbContext = _context.Item.Include(i => i.Supplier);
            return View(applicationDbContext.ToList());
        }

        public IActionResult Women(string Category)
        {
            var applicationDbContext = _context.Item.Include(i => i.Supplier);
            return RedirectToAction("Women", new RouteValueDictionary(
                new { controller = "Items", action = "Women", Names = Category }));
        }

        public IActionResult Men(string Category)
        {
            var applicationDbContext = _context.Item.Include(i => i.Supplier);
            return RedirectToAction("Men", new RouteValueDictionary(
                new { controller = "Items", action = "Men", Names = Category }));
        }

        [HttpGet]
        [HttpGet]

        public IActionResult Static()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
