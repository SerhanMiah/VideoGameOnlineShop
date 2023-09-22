using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Models.Product;
using VideoGameAppBackend.Models.Product;

namespace VideoGameAppBackend.Models
{
    public class Game
    {
        // =====================
        // Basic Properties
        // =====================
        
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100), Display(Name = "Title")]
        public string? Title { get; set; }

        [Required, Column(TypeName = "decimal(18, 2)"), Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required, DataType(DataType.Date), Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [StringLength(500), Display(Name = "Description")]
        public string? Description { get; set; }

        // =====================
        // Game Details
        // =====================

        [StringLength(255), Display(Name = "Developer")]
        public string? Developer { get; set; }

        [StringLength(255), Display(Name = "Publisher")]
        public string? Publisher { get; set; }

        [Display(Name = "Multiplayer Support")]
        public bool HasMultiplayerSupport { get; set; }

        [Display(Name = "Number of Local Players")]
        public int NumberOfLocalPlayers { get; set; }

        // =====================
        // Media Properties
        // =====================

        [DataType(DataType.Url), Display(Name = "Trailer URL")]
        public string? TrailerUrl { get; set; }

        public string? CoverImage { get; set; }  // Cover Image field

        public ICollection<GameImage>? GameImages { get; set; }

        // =====================
        // Ratings & Requirements
        // =====================

        [Display(Name = "Average Rating")]
        public double? AverageRating { get; set; }

        [Display(Name = "ESRB Content Descriptions")]
        public string? ESRBContentDescriptions { get; set; }

        [Display(Name = "Minimum System Requirements")]
        public string? MinimumSystemRequirements { get; set; }

        [Display(Name = "Recommended System Requirements")]
        public string? RecommendedSystemRequirements { get; set; }

        [Column(TypeName = "decimal(18, 2)"), Display(Name = "Discounted Price")]
        public decimal? DiscountedPrice { get; set; }

        // =====================
        // Relationships
        // =====================

        public virtual ICollection<GameGenre> GameGenres { get; set; } = new List<GameGenre>();
        public virtual ICollection<GamePlatform> GamePlatforms { get; set; } = new List<GamePlatform>();
        public ICollection<DLC> DLCs { get; set; } = new List<DLC>();
        public virtual ICollection<Language> SupportedLanguages { get; set; } = new List<Language>();

        public virtual ICollection<GameGameTag> GameGameTags { get; set; } = new List<GameGameTag>();

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();



        public int AgeRatingId { get; set; }
        [ForeignKey("AgeRatingId")]
        [Display(Name = "Age Rating")]
        public virtual AgeRating? AgeRating { get; set; }

        public virtual ICollection<OrderItem>? OrderItems { get; set; }

        // =====================
        // Timestamps
        // =====================

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

}
