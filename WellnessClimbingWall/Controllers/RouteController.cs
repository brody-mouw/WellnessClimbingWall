using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Models;
using WellnessClimbingWall.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WellnessClimbingWall.Controllers
{
    public class RouteController : Controller
    {
        private readonly IRouteRepository _routeRepository;

        public RouteController (IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }

        public ViewResult List()
        {
            RoutesListViewModel routesListViewModel = new RoutesListViewModel();
            routesListViewModel.Routes = _routeRepository.AllRoutes;

            return View(routesListViewModel);
        }
    }
}
