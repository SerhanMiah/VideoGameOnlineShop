using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Models;

namespace VideoGameAppBackend.Data.SeedData
{
 public class RoleSeedData
{
    public static void Seed(ModelBuilder builder, List<ApplicationUser> users)
    {
    
        var adminRoleId = Guid.NewGuid().ToString();
        var adminRole = new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" };
        builder.Entity<IdentityRole>().HasData(adminRole);

        builder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string> { UserId = users[0].Id, RoleId = adminRoleId });
    }
}

}