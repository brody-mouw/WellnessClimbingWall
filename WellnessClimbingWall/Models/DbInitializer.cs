using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellnessClimbingWall.Auth;
using WellnessClimbingWall.Data;

namespace WellnessClimbingWall.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                string[] roles = new string[] { "Administrators" };

                foreach (string role in roles)
                {
                    var roleStore = new RoleStore<IdentityRole>(context);

                    if (!context.Roles.Any(r => r.Name == role))
                    {
                        roleStore.CreateAsync(new IdentityRole(role));
                    }
                }

                var user = new ApplicationUser
                {
                    UserName = "Admin",
                    Id = "123456",
                };

                if (!context.Users.Any(u => u.UserName == user.UserName))
                {
                    var password = new PasswordHasher<ApplicationUser>();
                    var hashed = password.HashPassword(user, "Password1!");
                    user.PasswordHash = hashed;

                    var userStore = new UserStore<ApplicationUser>(context);
                    var result = userStore.CreateAsync(user);
                }

                AssignRoles(serviceScope.ServiceProvider, user.UserName, roles);

                context.SaveChanges();
            }
        }

        public static async Task<IdentityResult> AssignRoles(IServiceProvider s, string name, string[] roles)
        {
            UserManager<ApplicationUser> _userManager = s.GetService<UserManager<ApplicationUser>>();
            ApplicationUser user = await _userManager.FindByNameAsync(name);
            var result = await _userManager.AddToRolesAsync(user, roles);

            return result;
        }
    }
}
