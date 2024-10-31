using RoesteCrmServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.WebApi.Middlewares;

public static class ExtensionsMiddleware
{
    public static async Task CreateFirstUser(WebApplication app)
    {
        using (var scoped = app.Services.CreateScope())
        {
            var roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();
            var roles = new[]
            {
                new IdentityRole<Guid>{Id=Guid.NewGuid(), Name = "Admin"},
                new IdentityRole<Guid>{Id=Guid.NewGuid(), Name = "Manager"},
                new IdentityRole<Guid>{Id=Guid.NewGuid(), Name = "User"},
                new IdentityRole<Guid>{Id=Guid.NewGuid(), Name = "Visitor"},
            };

            foreach(var role in roles)
            {
                if (await roleManager.RoleExistsAsync(role.Name))
                {
                    continue;
                }

                await roleManager.CreateAsync(role);
            }
        }
        
        using (var scoped = app.Services.CreateScope())
        {
            var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
            if (!userManager.Users.Any(p => p.UserName == "admin"))
            {
                AppUser user = new()
                {
                    UserName = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Ibrahim",
                    LastName = "Cingi",
                    EmailConfirmed = true,
                };

                await userManager.CreateAsync(user, "Roccafella531.");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
