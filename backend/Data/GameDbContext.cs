using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Data.SeedData;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Payments;
using VideoGameAppBackend.Models.Product;
using System.Collections.Generic;
using backend.Models.Product;
using backend.Models.User;

namespace VideoGameAppBackend.Data
{
    public class GameDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;

        public GameDbContext(DbContextOptions<GameDbContext> options, IPasswordHasher<ApplicationUser> passwordHasher)
            : base(options)
        {
            _passwordHasher = passwordHasher;
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameImage> GameImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<DLC> DLCs { get; set; }
        public DbSet<DLCImage> DLCImages { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }
        public DbSet<GamePlatform> GamePlatforms { get; set; }
        public DbSet<AgeRating> AgeRatings { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<GameTag> Tags { get; set; }
        public DbSet<GameGameTag> GameGameTags { get; set; }


        public DbSet<WishList> WishLists { get; set; }

        public DbSet<WishlistItem> WishlistItems { get; set; }


        public DbSet<UserFriend> UserFriends { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var users = UserSeedData.Seed(builder, _passwordHasher) as List<ApplicationUser>; // Explicitly cast to List<ApplicationUser>
            RoleSeedData.Seed(builder, users);
            GameSeedData.Seed(builder);
            GameImageSeedData.Seed(builder);

            // Set seeding order: Games first, then GameImages
            builder.Entity<Game>()
                .HasMany(g => g.DLCs)
                .WithOne(d => d.Game)
                .HasForeignKey(d => d.GameId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            // Set the relationships for the Game, GameGenre, and GamePlatform entities
            builder.Entity<GameGenre>()
                .HasKey(gg => new { gg.GameId, gg.GenreId });

            builder.Entity<GameGenre>()
                .HasOne(gg => gg.Game)
                .WithMany(g => g.GameGenres)
                .HasForeignKey(gg => gg.GameId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<GameGenre>()
                .HasOne(gg => gg.Genre)
                .WithMany(g => g.GameGenres)
                .HasForeignKey(gg => gg.GenreId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<GamePlatform>()
                .HasKey(gp => new { gp.GameId, gp.PlatformId });

            builder.Entity<GamePlatform>()
                .HasOne(gp => gp.Game)
                .WithMany(g => g.GamePlatforms)
                .HasForeignKey(gp => gp.GameId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<GamePlatform>()
                .HasOne(gp => gp.Platform)
                .WithMany(p => p.GamePlatforms)
                .HasForeignKey(gp => gp.PlatformId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Set the relationship between Game and AgeRating
            builder.Entity<Game>()
                .HasOne(g => g.AgeRating)
                .WithMany(ar => ar.Games)
                .HasForeignKey(g => g.AgeRatingId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DLC>()
                .HasOne(d => d.DLCImage)
                .WithOne()
                .HasForeignKey<DLCImage>(di => di.DLCId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            // Set the relationship between Cart and CartItem
            builder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            // Set the relationship between ApplicationUser and Cart
            builder.Entity<ApplicationUser>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Set the relationship between user and Review
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Set the relationship between user and wishlist
            builder.Entity<ApplicationUser>()
                .HasMany(w => w.WishLists)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Set the relationships for the Game and Tag entities
            builder.Entity<GameGameTag>()
                .HasKey(ggt => new { ggt.GameId, ggt.GameTagId });

            builder.Entity<GameGameTag>()
                .HasOne(ggt => ggt.Game)
                .WithMany(g => g.GameGameTags)
                .HasForeignKey(ggt => ggt.GameId);

            builder.Entity<GameGameTag>()
                .HasOne(ggt => ggt.GameTag)
                .WithMany(gt => gt.GameGameTags)
                .HasForeignKey(ggt => ggt.GameTagId);


            // User Friend
            builder.Entity<UserFriend>()
                .HasKey(uf => new { uf.UserId, uf.FriendId });

            builder.Entity<UserFriend>()
                .HasOne(uf => uf.User)
                .WithMany(u => u.UserFriends)  
                .HasForeignKey(uf => uf.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<UserFriend>()
                .HasOne(uf => uf.Friend)
                .WithMany()
                .HasForeignKey(uf => uf.FriendId)
                .OnDelete(DeleteBehavior.Restrict);




        }
    }
}
