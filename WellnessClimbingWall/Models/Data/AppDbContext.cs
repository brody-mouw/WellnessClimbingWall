using Microsoft.EntityFrameworkCore;
using System;
using WellnessClimbingWall.Models;

namespace WellnessClimbingWall.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Route> Route {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed our routes
            modelBuilder.Entity<Route>().HasData(new Route
            { 
                RouteId = 1, 
                Grade = "5.5", 
                Color = "Blue", 
                DateCreated = new DateTime(2021, 1, 7), 
                Location = "None", 
                Rope = 21, 
                Setter = "John" 
            });

            modelBuilder.Entity<Route>().HasData(new Route 
            {   
                RouteId = 2, 
                Grade = "8.2", 
                Color = "Red",
                DateCreated = new DateTime(2021, 1, 10), 
                Location = "None", 
                Rope = 6, 
                Setter = "Jack"
            });

            modelBuilder.Entity<Route>().HasData(new Route 
            { 
                RouteId = 3, 
                Grade = "4.9", 
                Color = "Yellow", 
                DateCreated = new DateTime(2021, 1, 3), 
                Location = "North Wall", 
                Rope = 0, 
                Setter = "Charlie"
            });

            modelBuilder.Entity<Route>().HasData(new Route
            { 
                RouteId = 4, 
                Grade = "9.2", 
                Color = "Black", 
                DateCreated = new DateTime(2021, 1, 22), 
                Location = "None", 
                Rope = 11, 
                Setter = "Stacy"
            });
        }
    }
}