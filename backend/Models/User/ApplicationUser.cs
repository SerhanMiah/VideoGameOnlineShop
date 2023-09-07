// ApplicationUser.cs

using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    }

}
