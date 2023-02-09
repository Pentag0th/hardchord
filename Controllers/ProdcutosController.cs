using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hardchord.Models;
using hardchord.Data;

namespace hardchord.Controllers
{
    public class ProdcutosController : Controller
    {
        private readonly hardchordContext _context;

        public ProdcutosController(hardchordContext context)
        {
            _context = context;
        }

        // GET: Prodcutos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prodcutos.ToListAsync());
        }

        // GET: Prodcutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodcutos = await _context.Prodcutos
                .FirstOrDefaultAsync(m => m.idProductos == id);
            if (prodcutos == null)
            {
                return NotFound();
            }

            return View(prodcutos);
        }

        // GET: Prodcutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prodcutos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idProductos,ProductName,stock,price")] Prodcutos prodcutos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prodcutos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prodcutos);
        }

        // GET: Prodcutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodcutos = await _context.Prodcutos.FindAsync(id);
            if (prodcutos == null)
            {
                return NotFound();
            }
            return View(prodcutos);
        }

        // POST: Prodcutos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idProductos,ProductName,stock,price")] Prodcutos prodcutos)
        {
            if (id != prodcutos.idProductos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prodcutos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdcutosExists(prodcutos.idProductos))
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
            return View(prodcutos);
        }

        // GET: Prodcutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodcutos = await _context.Prodcutos
                .FirstOrDefaultAsync(m => m.idProductos == id);
            if (prodcutos == null)
            {
                return NotFound();
            }

            return View(prodcutos);
        }

        // POST: Prodcutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prodcutos = await _context.Prodcutos.FindAsync(id);
            _context.Prodcutos.Remove(prodcutos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdcutosExists(int id)
        {
            return _context.Prodcutos.Any(e => e.idProductos == id);
        }
    }
}
