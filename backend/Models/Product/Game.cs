using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VideoGameAppBackend.Models.Product;

namespace VideoGameAppBackend.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Title")]
        public string? Title { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        // Relationships with Genre and Platform
        public virtual ICollection<GameGenre>? GameGenres { get; set; }
        public virtual ICollection<GamePlatform>? GamePlatforms { get; set; }

        [InverseProperty("Game")]
        public ICollection<GameImage> GameImages { get; set; } = new List<GameImage>();

        [Display(Name = "Trailer URL")]
        [DataType(DataType.Url)]
        public string? TrailerUrl { get; set; }

        public int? GameImageId { get; set; }

        [ForeignKey("GameImageId")]
        public virtual GameImage? GameImage { get; set; }

        [Display(Name = "Developer")]
        public string? Developer { get; set; }

        [Display(Name = "Publisher")]
        public string? Publisher { get; set; }

        [Display(Name = "Average Rating")]
        public double? AverageRating { get; set; }

        [Display(Name = "Minimum System Requirements")]
        public string? MinimumSystemRequirements { get; set; }

        [Display(Name = "Recommended System Requirements")]
        public string? RecommendedSystemRequirements { get; set; }

        [Display(Name = "Multiplayer Support")]
        public bool HasMultiplayerSupport { get; set; }

        [Display(Name = "Number of Local Players")]
        public int NumberOfLocalPlayers { get; set; }

        [Display(Name = "DLCs")]
        public ICollection<DLC> DLCs { get; set; } = new List<DLC>();

        [Display(Name = "Discounted Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountedPrice { get; set; }

        [Display(Name = "Supported Languages")]
        public virtual ICollection<Language>? SupportedLanguages { get; set; }

        // Foreign key for AgeRating
        public int AgeRatingId { get; set; }

        [ForeignKey("AgeRatingId")]
        [Display(Name = "Age Rating")]
        public virtual AgeRating? AgeRating { get; set; }

        [Display(Name = "ESRB Content Descriptions")]
        public string? ESRBContentDescriptions { get; set; }

        public virtual ICollection<OrderItem>? OrderItems { get; set; }

    }
}

