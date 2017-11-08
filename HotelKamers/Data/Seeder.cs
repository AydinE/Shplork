using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelKamers.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace HotelKamers.Data
{
    public static class Seeder
    {
        public static void Initialize(this IApplicationBuilder app, IServiceProvider provider)
        {
            var userManager = provider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

            // check for roles 
            var managerRole = roleManager.FindByNameAsync("Hotelmanager").Result;
            if (managerRole == null)
            {
                managerRole = new IdentityRole("Hotelmanager");
                roleManager.CreateAsync(managerRole).Wait();
            }
            var guestRole = roleManager.FindByNameAsync("Guest").Result;
            if (guestRole == null)
            {
                guestRole = new IdentityRole("Guest");
                roleManager.CreateAsync(guestRole).Wait();
            }
            var recepRole = roleManager.FindByNameAsync("Receptionist").Result;
            if (recepRole == null)
            {
                recepRole = new IdentityRole("Receptionist");
                roleManager.CreateAsync(recepRole).Wait();
            }

            var adminUser = userManager.FindByNameAsync("info@snlakeresort.fr").Result;
            if (adminUser == null)
            {
                adminUser = new ApplicationUser() { UserName = "info@snlakeresort.fr", Email = "info@snlakeresort.fr", FirstName = "Klaas", LastName = "Versnel"};
                var result = userManager.CreateAsync(adminUser, "#n@Wsb9a94@G").Result;
                result = userManager.SetLockoutEnabledAsync(adminUser, false).Result;

                userManager.AddToRoleAsync(adminUser, managerRole.Name).Wait();
                userManager.AddToRoleAsync(adminUser, recepRole.Name).Wait();
            }

        }
    }
}
