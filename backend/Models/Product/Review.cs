using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VideoGameAppBackend.Models.Product
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1,5)] 
        public int Rating { get; set; }

        [Required]
        [StringLength(1000)]
        public string Title { get; set; } 

        [StringLength(5000)]
        public string Comment { get; set; } 

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public virtual Game? Game { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }

        public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
    }
}

