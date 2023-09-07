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
        public int Rating { get; set; }

        [StringLength(1000)]
        public string? Comment { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public virtual Game? Game { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }
    }
}