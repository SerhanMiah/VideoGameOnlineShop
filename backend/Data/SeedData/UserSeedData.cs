using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Models;

namespace VideoGameAppBackend.Data.SeedData
{
   public class UserSeedData
{
    public static List<ApplicationUser> Seed(ModelBuilder builder, IPasswordHasher<ApplicationUser> passwordHasher)
    {
        // Seeding an admin user
        var admin = new ApplicationUser
        {
            UserName = "admin",
            Email = "admin@videogameshop.com",
            NormalizedUserName = "ADMIN",
            NormalizedEmail = "ADMIN@VIDEOGAMESHOP.COM",
            EmailConfirmed = true,
            FirstName = "Admin",
            LastName = "User",
            SecurityStamp = Guid.NewGuid().ToString("D"),
        };
        admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123!");
        builder.Entity<ApplicationUser>().HasData(admin);

        // Seeding a regular user
        var user = new ApplicationUser
        {
            UserName = "user",
            Email = "user@videogameshop.com",
            NormalizedUserName = "USER",
            NormalizedEmail = "USER@VIDEOGAMESHOP.COM",
            EmailConfirmed = true,
            FirstName = "Regular",
            LastName = "User",
            SecurityStamp = Guid.NewGuid().ToString("D"),
        };
        user.PasswordHash = passwordHasher.HashPassword(user, "User123!");
        builder.Entity<ApplicationUser>().HasData(user);

        return new List<ApplicationUser> { admin, user };
        }
    }

}
