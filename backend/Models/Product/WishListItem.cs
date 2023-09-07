using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models.Product
{
    public class WishlistItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Wishlist")]
        public int WishlistId { get; set; }

        public virtual WishList? Wishlist { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public virtual Game? Game { get; set; }
        
    }
}