using Microsoft.AspNetCore.Identity;
using UpWork.Core.Constants;

namespace UpWork.Application.Services
{
    public static class RoleSeeder
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            var roles = new[]
            {
            ApplicationRoles.Admin,
            ApplicationRoles.Client,
            ApplicationRoles.Freelancer,
            ApplicationRoles.User
        };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }
        }
    }

}
