using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using store2.Models;
using System;
using System.Collections.Generic;

namespace store2.Controllers
{
    public class ItemsController : Controller
    {
        private ApplicationDbContext _context;
        
        public ItemsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Items
        public IActionResult Men(string Names, string SearchDetails, int MaxPrice, DateTime FromDate , DateTime EndDate ,string supplierSearch)
        {
            //List<Supplier> SupplierL = new List<Supplier>();
            //List<Item> ItemL = new List<Item>();

            var NameList = new List<string>();

            var q = from n in _context.Item where n.Category == "Men" select n.Name;
            NameList.AddRange(q.Distinct());
            ViewBag.Names = new SelectList(NameList);

            var SuppList = new List<string>();
            var a = from n in _context.Supplier select n.Name;
            SuppList.AddRange(a.Distinct());
            ViewBag.Suppliers = new SelectList(SuppList);

            var Items = from i in _context.Item select i;

            if (!String.IsNullOrEmpty(Names))
            {
                Items = Items.Where(s => s.Name == Names);
            }
            if (!String.IsNullOrEmpty(SearchDetails))
            {
                Items = Items.Where(d => d.Details.Contains(SearchDetails));
            }
            if (MaxPrice > 0)
            {
                Items = Items.Where(p => p.Price < MaxPrice);
            }
            if (FromDate != DateTime.MinValue)
            {
                Items = Items.Where(p => p.DateOfPublish >= FromDate );
            }
            if (EndDate != DateTime.MinValue)
            {
                Items = Items.Where(p => p.DateOfPublish <= EndDate);
            }


            //List<object> ListI = new List<object>();
            //ListI.Add(list.ToList());

            var applicationDbContext = _context.Item.Include(i => i.Supplier);
            return View(Items);
        }

        public IActionResult Women(string Names, string SearchDetails, int MaxPrice, DateTime FromDate, DateTime EndDate)
        {
            var NameList = new List<string>();

            var q = from n in _context.Item where n.Category == "Women" select n.Name;
            NameList.AddRange(q.Distinct());
            ViewBag.Names = new SelectList(NameList);

            var SuppList = new List<string>();
            var a = from n in _context.Supplier select n.Name;
            SuppList.AddRange(a.Distinct());
            ViewBag.Suppliers = new SelectList(SuppList);

            var Items = from i in _context.Item select i;

            if (!String.IsNullOrEmpty(Names))
            {
                Items = Items.Where(s => s.Name == Names);
            }
            if (!String.IsNullOrEmpty(SearchDetails))
            {
                Items = Items.Where(d => d.Details.Contains(SearchDetails));
            }
            if (MaxPrice > 0)
            {
                Items = Items.Where(p => p.Price < MaxPrice);
            }
            if (FromDate != DateTime.MinValue)
            {
                Items = Items.Where(p => p.DateOfPublish >= FromDate);
            }
            if (EndDate != DateTime.MinValue)
            {
                Items = Items.Where(p => p.DateOfPublish <= EndDate);
            }
            var applicationDbContext = _context.Item.Include(i => i.Supplier);
            return View(Items);
        }
        public IActionResult Children(string Names, string SearchDetails, int MaxPrice, DateTime FromDate, DateTime EndDate)
        {
            var NameList = new List<string>();

            var q = from n in _context.Item where n.Category == "Children" select n.Name;
            NameList.AddRange(q.Distinct());
            ViewBag.Names = new SelectList(NameList);

            var SuppList = new List<string>();
            var a = from n in _context.Supplier select n.Name;
            SuppList.AddRange(a.Distinct());
            ViewBag.Suppliers = new SelectList(SuppList);

            var Items = from i in _context.Item select i;

            if (!String.IsNullOrEmpty(Names))
            {
                Items = Items.Where(s => s.Name == Names);
            }
            if (!String.IsNullOrEmpty(SearchDetails))
            {
                Items = Items.Where(d => d.Details.Contains(SearchDetails));
            }
            if (MaxPrice > 0)
            {
                Items = Items.Where(p => p.Price < MaxPrice);
            }
            if (FromDate != DateTime.MinValue)
            {
                Items = Items.Where(p => p.DateOfPublish >= FromDate);
            }
            if (EndDate != DateTime.MinValue)
            {
                Items = Items.Where(p => p.DateOfPublish <= EndDate);
            }
            var applicationDbContext = _context.Item.Include(i => i.Supplier);
            return View(Items);
        }
        public IActionResult PageItem(int ID)
        {

            var Item = from i in _context.Item select i;

            Item = Item.Where(p => p.ID == ID);
            
            var applicationDbContext = _context.Item.Include(i => i.Supplier);
            return View(Item);
        }


        // GET: Items/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Item item = _context.Item.Single(m => m.ID == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create(string Suppliers,string Categories)
        {
            var CategoryList = new List<string>();
            var q = from c in _context.Item select c.Category;
            CategoryList.AddRange(q.Distinct());
            ViewBag.Categories = new SelectList(CategoryList);

            var SupplierList = new List<string>();
            var query = from s in _context.Supplier select s.Name;
            SupplierList.AddRange(query.Distinct());
            ViewBag.Suppliers = new SelectList(SupplierList);
            
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "ID", "Supplier");
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item , string Suppliers, string Categories)
        {
            Supplier sup = _context.Supplier.Where(d => d.Name == Suppliers).Single();
            item.Supplier = sup;
            if (ModelState.IsValid)
            {
                item.DateOfPublish = DateTime.Now;
                item.Category = Categories;
                item.Supplier.Name = Suppliers;
                _context.Item.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Men");
            }

            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "ID", "Supplier", item.SupplierID);
            return View(item);
        }

        // GET: Items/Edit/5
        public IActionResult Edit(int? id, string Suppliers,string Categories)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Item item = _context.Item.Single(m => m.ID == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            var CategoryList = new List<string>();
            var q = from c in _context.Item select c.Category;
            CategoryList.AddRange(q.Distinct());
            ViewBag.Categories = new SelectList(CategoryList);

            var SupplierList = new List<string>();
            var query = from s in _context.Supplier select s.Name;
            SupplierList.AddRange(query.Distinct());
            ViewBag.Suppliers = new SelectList(SupplierList);

            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "ID", "Supplier");
            return View(item);
        }

        // POST: Items/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item item, string Suppliers, string Categories)
        {
            Supplier sup = _context.Supplier.Where(d => d.Name == Suppliers).Single();
            item.Supplier = sup;
            if (ModelState.IsValid)
            {
                item.Category = Categories;
                item.Supplier.Name = Suppliers;
                _context.Update(item);
                _context.SaveChanges();
                return RedirectToAction("Men");
            }
            ViewData["SupplierID"] = new SelectList(_context.Set<Supplier>(), "ID", "Supplier", item.SupplierID);
            return View(item);
        }

        // GET: Items/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Item item = _context.Item.Single(m => m.ID == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Item item = _context.Item.Single(m => m.ID == id);
            _context.Item.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Men");
        }
    }
}
