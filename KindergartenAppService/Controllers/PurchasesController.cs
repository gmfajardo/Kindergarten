﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KindergartenAppService.Models;

namespace KindergartenAppService.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly KindergarterContext _context;

        public PurchasesController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Purchases
        public async Task<IActionResult> Index()
        {
            var kindergarterContext = _context.Purchases.Include(p => p.Provider);
            return View(await kindergarterContext.ToListAsync());
        }

        // GET: Purchases/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchases
                .Include(p => p.Provider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        // GET: Purchases/Create
        public IActionResult Create()
        {
            ViewData["ProviderID"] = new SelectList(_context.Providers, "Id", "Id");
            return View();
        }

        // POST: Purchases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Sequence,Document,GeneratedDate,DueDate,ProviderID,Amount,Id")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                purchase.Id = Guid.NewGuid();
                _context.Add(purchase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProviderID"] = new SelectList(_context.Providers, "Id", "Id", purchase.ProviderID);
            return View(purchase);
        }
        public async Task<IActionResult> NewPurchase()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewPurchase(Purchase purchase)
        {
            return View();
        }
        // GET: Purchases/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchases.FindAsync(id);
            if (purchase == null)
            {
                return NotFound();
            }
            ViewData["ProviderID"] = new SelectList(_context.Providers, "Id", "Id", purchase.ProviderID);
            return View(purchase);
        }

        // POST: Purchases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Sequence,Document,GeneratedDate,DueDate,ProviderID,Amount,Id")] Purchase purchase)
        {
            if (id != purchase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseExists(purchase.Id))
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
            ViewData["ProviderID"] = new SelectList(_context.Providers, "Id", "Id", purchase.ProviderID);
            return View(purchase);
        }

        // GET: Purchases/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchases
                .Include(p => p.Provider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var purchase = await _context.Purchases.FindAsync(id);
            _context.Purchases.Remove(purchase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseExists(Guid id)
        {
            return _context.Purchases.Any(e => e.Id == id);
        }
    }
}
