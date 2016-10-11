using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using store2.Models;

namespace store2.Controllers
{
    public class BranchesController : Controller
    {
        private ApplicationDbContext _context;

        public BranchesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Branches
        public IActionResult Index()
        {
            return View(_context.Branch.ToList());
        }

        // GET: Branches/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Branch branch = _context.Branch.Single(m => m.ID == id);
            if (branch == null)
            {
                return HttpNotFound();
            }

            return View(branch);
        }

        // GET: Branches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Branches/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Branch branch)
        {
            if (ModelState.IsValid)
            {
                _context.Branch.Add(branch);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(branch);
        }

        // GET: Branches/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Branch branch = _context.Branch.Single(m => m.ID == id);
            if (branch == null)
            {
                return HttpNotFound();
            }
            return View(branch);
        }

        // POST: Branches/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Branch branch)
        {
            if (ModelState.IsValid)
            {
                _context.Update(branch);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(branch);
        }

        // GET: Branches/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Branch branch = _context.Branch.Single(m => m.ID == id);
            if (branch == null)
            {
                return HttpNotFound();
            }

            return View(branch);
        }

        // POST: Branches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Branch branch = _context.Branch.Single(m => m.ID == id);
            _context.Branch.Remove(branch);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult getAddresses()
        {
            var address = _context.Branch.Select(branch => branch.Address);

            return Json(address);
        }





    }
}
