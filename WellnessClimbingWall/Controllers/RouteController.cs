using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Models;
using WellnessClimbingWall.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WellnessClimbingWall.Data;
using Microsoft.AspNetCore.Authorization;

namespace WellnessClimbingWall.Controllers
{
    [Authorize]
    public class RouteController : Controller
    {

        private readonly IRouteRepository _routeRepository;
        private readonly AppDbContext _context;

        public RouteController (IRouteRepository routeRepository, AppDbContext context)
        {
            _routeRepository = routeRepository;
            _context = context;
        }

        public ViewResult List()
        {
            RoutesListViewModel routesListViewModel = new RoutesListViewModel();
            routesListViewModel.Routes = _routeRepository.AllRoutes;

            return View(routesListViewModel);
        }

        public ActionResult Index()
        {
            return View(_routeRepository.AllRoutes);
        }

        // GET: Routes/Edit
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var route = await _context.Route.FindAsync(id);
            if (route == null)
            {
                return NotFound();
            }
            return View(route);
        }

        // POST: Routes/Edit
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RouteId,Grade,Color,Rope,DateCreated,Location,Setter")] Route route)
        {
            if (id != route.RouteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(route);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RouteExists(route.RouteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("List");
            }
            return View(route);
        }

        private bool RouteExists(int id)
        {
            return _context.Route.Any(e => e.RouteId == id);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var route = await _context.Route.FirstOrDefaultAsync(m => m.RouteId == id);
            if (route == null)
            {
                return NotFound();
            }
            return View(route);
        }
        //POST: Route/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var route = await _context.Route.FindAsync(id);
            _context.Route.Remove(route);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Route());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Route route)
        {
            if (ModelState.IsValid && route.Grade != null)
            {
                try
                {
                    _context.Update(route);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RouteExists(route.RouteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("List");
            }
            return View(route);
        }
    }
}
