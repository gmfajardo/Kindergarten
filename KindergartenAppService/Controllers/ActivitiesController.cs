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
    public class ActivitiesController : Controller
    {
        private readonly KindergarterContext _context;

        public ActivitiesController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Activities
        public async Task<IActionResult> Index()
        {
            var kindergarterContext = _context.Activity.Include(a => a.ActivityTemplate);
            return View(await kindergarterContext.ToListAsync());
        }

        // GET: Activities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = await _context.Activity
                .Include(a => a.ActivityTemplate)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activity == null)
            {
                return NotFound();
            }

            return View(activity);
        }

        // GET: Activities/Create
        public IActionResult Create()
        {
            ViewData["ActivityTemplateId"] = new SelectList(_context.ActivityTemplate, "Id", "Description");
            return View();
        }

        // POST: Activities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,ActivityTemplateId,Id")] Activity activity)
        {
            if (ModelState.IsValid)
            {
                activity.Id = Guid.NewGuid();
                _context.Add(activity);
                await _context.SaveChangesAsync();
                TempData["SuccessfullMessage"] = "Actividad creada satisfactoriamente.";

                return RedirectToAction(nameof(Details),activity);
            }
            ViewData["ActivityTemplateId"] = new SelectList(_context.ActivityTemplate, "Id", "Description", activity.ActivityTemplateId);
            return View(activity);
        }

        // GET: Activities/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = await _context.Activity.FindAsync(id);
            if (activity == null)
            {
                return NotFound();
            }
            ViewData["ActivityTemplateId"] = new SelectList(_context.ActivityTemplate, "Id", "Description", activity.ActivityTemplateId);
            return View(activity);
        }

        // POST: Activities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Description,ActivityTemplateId,Id")] Activity activity)
        {
            if (id != activity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivityExists(activity.Id))
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
            ViewData["ActivityTemplateId"] = new SelectList(_context.ActivityTemplate, "Id", "Description", activity.ActivityTemplateId);
            return View(activity);
        }

        // GET: Activities/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = await _context.Activity
                .Include(a => a.ActivityTemplate)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activity == null)
            {
                return NotFound();
            }

            return View(activity);
        }

        // POST: Activities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var activity = await _context.Activity.FindAsync(id);
            _context.Activity.Remove(activity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivityExists(Guid id)
        {
            return _context.Activity.Any(e => e.Id == id);
        }
    }
}
