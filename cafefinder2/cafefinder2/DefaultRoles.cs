using cafefinder2.Data;
using Microsoft.AspNetCore.Identity;

public static class DefaultRoles
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        await roleManager.CreateAsync(new IdentityRole(Rule.Admin.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Rule.cafe_admin.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Rule.User.ToString()));
    }
}