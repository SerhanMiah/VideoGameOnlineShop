using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models
{
    public class GameImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string? Url { get; set; }

        public int GameId { get; set; }

        [ForeignKey("GameId")]
        public virtual Game? Game { get; set; }
    }
}
