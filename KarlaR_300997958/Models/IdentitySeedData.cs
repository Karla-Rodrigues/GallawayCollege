using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Mary";
        private const string adminPassword = "Password#123";
        private const string adminRole = "Admin";

        private const string generalUser = "Peter";
        private const string generalPassword = "Password#456";
        private const string generalRole = "General";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            // --------------------

            RoleManager<IdentityRole> roleManager = app.ApplicationServices
            .GetRequiredService<RoleManager<IdentityRole>>();

            IdentityRole adminR = await roleManager.FindByIdAsync(adminRole);
            if (adminR == null)
            {
                adminR = new IdentityRole(adminRole);
                await roleManager.CreateAsync(adminR);
            }

            UserManager<IdentityUser> userManager = app.ApplicationServices
            .GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser adminU = await userManager.FindByIdAsync(adminUser);
            if (adminU == null)
            {
                adminU = new IdentityUser(adminUser);
                await userManager.CreateAsync(adminU, adminPassword);
                await userManager.AddToRoleAsync(adminU, adminRole);
            }
            else
            { if (!(await userManager.IsInRoleAsync(adminU, adminRole)))
                {
                    await userManager.AddToRoleAsync(adminU, adminRole);
                }
            }

            // --------------------

            IdentityRole adminG = await roleManager.FindByIdAsync(generalRole);
            if (adminG == null)
            {
                adminG = new IdentityRole(generalRole);
                await roleManager.CreateAsync(adminG);
            }

            IdentityUser generalU = await userManager.FindByIdAsync(generalUser);
            if (generalU == null)
            {
                generalU = new IdentityUser(generalUser);
                await userManager.CreateAsync(generalU, generalPassword);
                await userManager.AddToRoleAsync(generalU, generalRole);
            }
            else
            {
                if (!(await userManager.IsInRoleAsync(generalU, generalRole)))
                {
                    await userManager.AddToRoleAsync(generalU, generalRole);
                }
            }
        }
    }
}