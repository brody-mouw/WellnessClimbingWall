using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellnessClimbingWall.Models
{
    public class MockRouteRepository : IRouteRepository
    {
        public IEnumerable<Route> AllRoutes
        {
            get
            {
                return new List<Route>
                {
                    new Route {RouteId = 1, Grade="5.5", Color="Blue", DateCreated = new DateTime(2021, 1, 7), Location="None", Rope=21, Setter="John"},
                    new Route {RouteId = 2, Grade="8.2", Color="Red", DateCreated = new DateTime(2021, 1, 10), Location="None", Rope=6, Setter="Jack"},
                    new Route {RouteId = 3, Grade="4.9", Color="Yellow", DateCreated = new DateTime(2021, 1, 3), Location="North Wall", Rope=0, Setter="Charlie"},
                    new Route {RouteId = 4, Grade="9.2", Color="Black", DateCreated = new DateTime(2021, 1, 22), Location="None", Rope=11, Setter="Stacy"},
                };
            }
        }

        public Route GetRouteById(int routeId)
        {
            throw new System.NotImplementedException();
        }
    }
}
