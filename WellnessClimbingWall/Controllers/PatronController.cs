using System;
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
        private List<Visit> visitList;      //Display for table


        public PatronController(IPatronRepository patronRepository, AppDbContext context)
        {
            _patronRepository = patronRepository;
            _context = context;
            visitList = new List<Visit>();
        }

        public ViewResult PatronView()
        {
            PatronListViewModel patronListViewModel = new PatronListViewModel();
            patronListViewModel.Patrons = _patronRepository.AllPatrons;

            ViewData["visitList"] = visitList;

            return View(patronListViewModel);
        }
        [HttpGet]
        [Route("/Patron/CheckIn/{id}")]
        public IActionResult CheckIn(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var patron = _context.Patron.Find(id);
                if (!visitList.Any(p => p.ID == patron.ID))     //If the current displayed list already has the patron, don't add them
                {
                    Visit newVisit = new Visit();
                    newVisit.ID = patron.ID;
                    newVisit.Name = patron.Name;
                    newVisit.Certifications = patron.Certifications;
                    newVisit.timeIn = DateTime.Now;
                    visitList.Add(newVisit);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Route());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Patron patron)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patron);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
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

        private bool PatronExists(int id)
        {
            return _context.Patron.Any(e => e.ID == id);
        }

        public void CheckOut(Patron patron)
        {
            if (patron == null)
            {
                throw new Exception("Patron does not exist");
            }
            else
            {
                Visit result = visitList.Find(x => x.ID == patron.ID);
                result.timeOut = DateTime.Now;
                //Save to Visit Database visitContext.Add(result)
                visitList.Remove(result);
            }
        }
    }
}
