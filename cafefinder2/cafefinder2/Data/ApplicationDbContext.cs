using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace cafefinder2.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>().Property(p => p.Rezerv).HasConversion(p=> JsonConvert.SerializeObject(p),p=>JsonConvert.DeserializeObject<Dictionary<string, string>>(p));
        builder.Entity<ApplicationUser>().Property(p => p.StarRating).HasConversion(
            p=> JsonConvert.SerializeObject(p),
            p=>

                JsonConvert.DeserializeObject<Dictionary<string, KeyValuePair<string, float>>>(p)
                );
        builder.Entity<ApplicationUser>().Property(p => p.Photo).HasConversion(p=> JsonConvert.SerializeObject(p),p=>JsonConvert.DeserializeObject<Dictionary<string, object>>(p));
        builder.Entity<ApplicationUser>().Property(p => p.Rule).HasConversion(p => JsonConvert.SerializeObject(p), p => JsonConvert.DeserializeObject<Rule>(p));
        builder.Entity<ApplicationUser>().Property(p => p.Rule).IsRequired();
       
        base.OnModelCreating(builder);
    }
}
