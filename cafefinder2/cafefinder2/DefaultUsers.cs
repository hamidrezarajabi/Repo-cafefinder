using cafefinder2.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

public static class DefaultUsers
{
    public static async Task SeedBasicUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
    {
        var us = new List<ApplicationUser>()
        {
            new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                Rule = Rule.Admin,
            }, new ApplicationUser
            {
                UserName = "admi",
                Email = "admi2@gmail.com",
                EmailConfirmed = true,
                Rule = Rule.Admin,
            },new ApplicationUser
            {
                UserName = "my-moon",
                Email = "my-moon@gmail.com",
                EmailConfirmed = true,
                Rule = Rule.cafe_admin,
                Name="کافه ماه من" , Neaber="سجاد",
                Cafe = true,
                Restaurant = false,
                FreeSmoke = true,
                FoodAndDrink = false,
                OpenSpace = true,
                RoofGarden = false,
                FreeTime = true,
                BirthdayTheme = false,
                BookCafe = false,
                Addres = "بلوار سجاد، پاساژ لاله ، انتهای پاساژ طبقه اول",
                Link = "https://www.mrk.co.ir",
                LocationLink = "https://www.mrk.co.ir",
            },new ApplicationUser
            {
                UserName = "aknon-home",
                Email = "aknon-home@gmail.com",
                EmailConfirmed = true,
                Rule = Rule.cafe_admin,
                Name="کافه خانه اکنون" , Neaber="سجاد",
                Cafe = true,
                Restaurant = true,
                FreeSmoke = true,
                FoodAndDrink = false,
                OpenSpace = true,
                RoofGarden = true,
                FreeTime = true,
                BirthdayTheme = false,
                BookCafe = true,
                Addres = "بلوار سجاد ،چهارراه گلریز ، گلریز4،یاس3",
                Link = "https://www.mrk.co.ir",
                LocationLink = "https://www.mrk.co.ir",
            },new ApplicationUser
            {
                UserName = "layali-lobnan",
                Email = "layali-lobnan@gmail.com",
                EmailConfirmed = true,
                Rule = Rule.cafe_admin,
                Name="رستوران لیالی لبنان" , Neaber="وکیل آباد",
                Cafe = false,
                Restaurant = true,
                FreeSmoke = false,
                FoodAndDrink = false,
                OpenSpace = false,
                RoofGarden = false,
                FreeTime = true,
                BirthdayTheme = false,
                BookCafe = false,
                Addres = "وکیل آباد 13",
                Link = "https://www.miranagency.ir",
                LocationLink = "https://www.miranagency.ir",
            },
        };
        foreach (var defaultUser in us)
        {
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByNameAsync(defaultUser.UserName);
                if (user == null)
                {
                  var d = await userManager.CreateAsync(defaultUser, "admin123456") ;
                    var r = defaultUser.Rule.ToString();
                    await userManager.AddToRoleAsync(defaultUser, r);
                }
            }
        }

    }



}