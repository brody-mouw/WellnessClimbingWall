﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Models;
using WellnessClimbingWall.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WellnessClimbingWall.Data;
using Microsoft.AspNetCore.Authorization;

namespace WellnessClimbingWall.Controllers
{
    [Authorize(Roles = "Administrators, Staff")]
    public class PatronController : Controller
    {
        private readonly IPatronRepository _patronRepository;
        private readonly AppDbContext _context;
        //Add visit repository


        public PatronController(IPatronRepository patronRepository, AppDbContext context)
        {
            _patronRepository = patronRepository;
            _context = context;
        }

        public ViewResult PatronView()
        {
            PatronListViewModel patronListViewModel = new PatronListViewModel();
            patronListViewModel.Patrons = _patronRepository.AllPatrons;

            return View(patronListViewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_AddPatronView", new Patron());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Patron patron)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var insertPatron = patron;
                    insertPatron.Certifications = "None";
                    _context.Update(insertPatron);
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatronExists(patron.ID))
                    {
                        throw;
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("PatronView");
            }
            return View(patron);
        }
        [HttpGet]
        public IActionResult Edit(int ?ID)
        { 
            if(ID == null)
            {
                return NotFound();
            }
            Patron patron = _context.Patron.Find(ID);
            if(patron == null)
            {
                return NotFound();
            }
            return PartialView("_EditPatron", patron);
        }

        [HttpPost]
        public IActionResult Edit(int ID, Patron patron)
        {
            if(ID != patron.ID)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(patron);
                    _context.SaveChanges();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!PatronExists(patron.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("PatronView");
            }
            return View(patron);
        }
        public IActionResult Delete(int id)
        {
            var patron = _context.Patron.FirstOrDefault(m => m.ID == id);
            _context.Patron.Remove(patron);
            _context.SaveChanges();
            return RedirectToAction(nameof(PatronView));
        }

        private bool PatronExists(int id)
        {
            return _context.Patron.Any(e => e.ID == id);
        }

        [HttpPost]
        public void CheckOut(int id, DateTime timeIn)
        {
            if (id == 0)
            {
                throw new Exception("Patron does not exist");
            }
            else
            {
                var patron = _context.Patron.FirstOrDefault(m => m.BadgeNumber == id);
                Visit result = new Visit { Name = patron.Name, ID = patron.ID, Certifications = patron.Certifications, timeIn = timeIn };
                result.timeOut = DateTime.Now;
                //Save to Visit Database visitContext.Add(result)
                _context.Visit.Update(result);
                _context.SaveChanges();
            }
        }
    }
}
