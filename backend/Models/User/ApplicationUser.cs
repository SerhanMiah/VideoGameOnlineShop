using backend.Models.Payments;
using backend.Models.User;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using VideoGameAppBackend.Models.Payments;
using VideoGameAppBackend.Models.Product;

namespace VideoGameAppBackend.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string? FirstName { get; set; }

        [StringLength(50)]
        public string? LastName { get; set; }

        [StringLength(100)]
        public string? Address { get; set; } = string.Empty;

        [StringLength(50)]
        public string? City { get; set; }

        [StringLength(50)]
        public string? State { get; set; }

        [StringLength(10)]
        public string? PostalCode { get; set; }

        [StringLength(50)]
        public string? Country { get; set; }

        public virtual Cart? Cart { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }

        public virtual ICollection<Review>? Reviews { get; set; }

        public virtual ICollection<WishList>? WishLists { get; set; }

        public string? FavoriteGame { get; set; }

        public int TotalGamesPlayed { get; set; }

        [NotMapped]
        public ICollection<string> Achievements { get; set; } = new List<string>();

        public string AchievementsDb
        {
            get { return Achievements != null ? string.Join(",", Achievements) : ""; }
            set { Achievements = value?.Split(',').ToList() ?? new List<string>(); }
        }

        public ICollection<Game> GameLibrary { get; set; } = new List<Game>();

        public virtual ICollection<UserFriend> UserFriends { get; set; } = new List<UserFriend>();

        public string? Bio { get; set; }

        public int? DefaultBillingId { get; set; }
        [ForeignKey("DefaultBillingId")]
        public virtual Billing? DefaultBillingDetails { get; set; }

    }
}
