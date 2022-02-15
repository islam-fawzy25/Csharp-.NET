using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBFirst_Layout_Routing.Models;

namespace DBFirst_Layout_Routing.Controllers
{
    public class OrdersController : Controller
    {
        private readonly SalesDBContext _context;

        public OrdersController(SalesDBContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var salesDBContext = _context.Orders.Include(o => o.CidNavigation).Include(o => o.PidNavigation);
            return View(await salesDBContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.CidNavigation)
                .Include(o => o.PidNavigation)
                .FirstOrDefaultAsync(m => m.Oid == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["Cid"] = new SelectList(_context.Customers, "Cid", "Name");
            ViewData["Pid"] = new SelectList(_context.Products, "Pid", "Name");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Oid,Cid,Pid,Qty,OrderDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cid"] = new SelectList(_context.Customers, "Cid", "Name", order.Cid);
            ViewData["Pid"] = new SelectList(_context.Products, "Pid", "Name", order.Pid);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["Cid"] = new SelectList(_context.Customers, "Cid", "Name", order.Cid);
            ViewData["Pid"] = new SelectList(_context.Products, "Pid", "Name", order.Pid);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Oid,Cid,Pid,Qty,OrderDate")] Order order)
        {
            if (id != order.Oid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Oid))
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
            ViewData["Cid"] = new SelectList(_context.Customers, "Cid", "Name", order.Cid);
            ViewData["Pid"] = new SelectList(_context.Products, "Pid", "Name", order.Pid);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.CidNavigation)
                .Include(o => o.PidNavigation)
                .FirstOrDefaultAsync(m => m.Oid == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Oid == id);
        }
    }
}
