using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Data;

namespace WellnessClimbingWall.Models
{
    public class RouteRepository : IRouteRepository
    {
        private readonly AppDbContext _appDbContext;

        public RouteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Route> AllRoutes
        {
            get
            {
                return _appDbContext.Route;
            }
        }

        public Route GetRouteById(int routeId)
        {
            return _appDbContext.Route.FirstOrDefault(p => p.RouteId == routeId);
        }
    }
}
