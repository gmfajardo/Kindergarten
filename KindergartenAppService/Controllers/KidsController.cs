﻿using KindergartenAppService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Controllers
{

    [Authorize]
    public class KidsController : Controller
    {
        private readonly KindergarterContext _context;

        public KidsController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Kids
        //[AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var kindergarterContext = _context.Kid.Include(k => k.Kindergarter).Include(k => k.TutorPrincipal).Include(k=>k.Enrollment);
            return View(await kindergarterContext.ToListAsync());
        }

        // GET: Kids/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var kid = await _context.Kid
                .Include(k => k.Kindergarter)
                .Include(k => k.TutorPrincipal)
                .Include(k => k.TutorSecundary)
                .Include(k => k.TutorAutorized)
                .Include(k => k.Pediatrician)
                .Include(k => k.Enrollment)
                .Include(k => k.Enrollment.EnrollActivities)
                .Include("Enrollment.EnrollActivities")
                .Include("Enrollment.EnrollActivities.Activity")
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kid == null)
            {
                return NotFound();
            }

            return View(kid);
        }

        // GET: Kids/Create
        public IActionResult Create()
        {
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Description");
            ViewData["TutorId"] = new SelectList(_context.Tutors.OrderBy(t=>t.FullName), "Id", "FullName",null);
            ViewData["PediatricianId"] = new SelectList(_context.Pediatrician.OrderBy(p=>p.Name), "Id", "Name");
            var a = _context.Pediatrician;
            return View();
        }

        // POST: Kids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,SecondName,FatherName,MotherName,Diseases,TShirtSize,SiblingCount,FavoriteActivities," +
            "Address,Sex,Grade,KindergarterId,TutorPrincipalId,TutorSecundaryId,TutorAutorizedId,PediatricianId,BirthDate,Id")] Kid kid)
        {
            if (ModelState.IsValid)
            {
                kid.Id = Guid.NewGuid();
                _context.Add(kid);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                //ViewBag.MensajeCreado = "El niño ha sido creado exitosamente";
                //ViewData["Mensaje"] = "El niño ha sido creado exitosamente";
                TempData["TempMessage"] = "Niño creado exitosamente.";
                return RedirectToAction(nameof(Details), kid);
                //return View("Details",kid);
            }
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Id", kid.KindergarterId);
            return View(kid);
        }

        // GET: Kids/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kid = await _context.Kid.FindAsync(id);
            if (kid == null)
            {
                return NotFound();
            }
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Description", kid.KindergarterId);
            ViewData["TutorId"] = new SelectList(_context.Tutors, "Id", "FullName", kid.TutorPrincipalId);
            ViewData["PediatricianId"] = new SelectList(_context.Pediatrician, "Id", "Name");
            return View(kid);
        }

        // POST: Kids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FirstName,SecondName,FatherName,MotherName,Diseases,TShirtSize,SiblingCount,FavoriteActivities," +
            "Address,Sex,Grade,KindergarterId,TutorPrincipalId,TutorSecundaryId,TutorAutorizedId,PediatricianId,BirthDate,Id")] Kid kid)
        {
            if (id != kid.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KidExists(kid.Id))
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
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Description", kid.KindergarterId);
            return View(kid);
        }

        // GET: Kids/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kid = await _context.Kid
                .Include(k => k.Kindergarter)
                .Include(k => k.TutorPrincipal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kid == null)
            {
                return NotFound();
            }

            return View(kid);
        }

        // POST: Kids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var kid = await _context.Kid.FindAsync(id);
            _context.Kid.Remove(kid);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KidExists(Guid id)
        {
            return _context.Kid.Any(e => e.Id == id);
        }
        public async Task<IActionResult> Enroll(Guid? id)
        {
            TempData["Kid"] = id;
            TempData["CameFromKid"] = "true";
            return RedirectToAction("Create", "Enrollments");
        }
        public async Task<IActionResult> EnrollActivity(Guid? id)
        {
            TempData["Enroll"] = id;
            TempData["CameFromKid"] = "true";
            return RedirectToAction("Create", "EnrollActivities");
        }
        public async Task<IActionResult> AssignPediatrician(Guid? id)
        {
            TempData["Kid"] = id;
            TempData["CameFromKid"] = "true";
            return RedirectToAction("Create", "Pediatrician");
        }
        public async Task<IActionResult> BirthDayReport()
        {
            var kids = _context.Kid.ToList();
            return View(kids);
        }
    }
}
