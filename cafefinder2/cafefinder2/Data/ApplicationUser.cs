using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace cafefinder2.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public Rule Rule { get; set; } = Rule.User;
    public string? Name {  get; set; }
    public string? Neaber {  get; set; }
    public string? Addres {  get; set; }
    public string? WorkTime { get; set; }
    public bool Cafe { get; set; } = false;
    public bool Restaurant { get; set; }=false; 
    public bool FoodAndDrink { get { return (Cafe && Restaurant); } set { if (value == true) { Cafe = true; Restaurant = true; } } }
    public bool FreeSmoke { get; set; }
    public bool FreeTime { get; set; }
    public bool BirthdayTheme { get; set; }
    public bool RoofGarden { get; set; }
    public bool BookCafe { get; set; }
    public bool OpenSpace { get; set; }
    public string? Link { get; set; }
    public string? LocationLink { get; set; }
    public Dictionary<string, string>? Rezerv { get; set; } = new();
    public Dictionary<string,KeyValuePair<string,float>>? StarRating { get; set; }=new();
    public Dictionary<string,object>? Photo { get; set; } = new();
    public List<string>? SelectRezerv { get; set; } = new List<string>();
}

public enum Rule
{
    Admin,
    cafe_admin,
    User
}