using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public interface IRouteRepository
    {
        IEnumerable<Route> AllRoutes { get; }
        Route GetRouteById(int routeID);
    }
}
