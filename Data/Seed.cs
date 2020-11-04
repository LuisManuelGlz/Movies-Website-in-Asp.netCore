using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MovieDB.Models;
using Newtonsoft.Json;

namespace MovieDB.Data
{
    public class Seed
    {
        public static void SeedRoles(ApplicationDbContext context) {
            if (!context.Users.Any())
            {
                List<IdentityRole> roles = new List<IdentityRole>
                {
                    new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }
                };
                foreach (var role in roles)
                {
                    context.Roles.AddAsync(role);
                }
                context.SaveChanges();
            }
        }
    }
}