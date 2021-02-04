using Microsoft.EntityFrameworkCore;
using WellnessClimbingWall.Models;

namespace WellnessClimbingWall.Data
{
    public class RouteContext : DbContext
    {
        public RouteContext (DbContextOptions<RouteContext> options) : base(options)
        {

        }
        public DbSet<Route> Route {get; set;}
    }
}