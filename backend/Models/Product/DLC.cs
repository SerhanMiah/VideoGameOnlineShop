using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models.Product
{
    public class DLC
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "DLC Name")]
        public string? DLCName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Developer")]
        public string? Developer { get; set; }

        [Display(Name = "Publisher")]
        public string? Publisher { get; set; }

        [Display(Name = "Discounted Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DiscountedPrice { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public virtual Game? Game { get; set; }

        [Display(Name = "Minimum System Requirements")]
        public string? MinimumSystemRequirements { get; set; }

        [Display(Name = "Recommended System Requirements")]
        public string? RecommendedSystemRequirements { get; set; }

        [Display(Name = "Supported Languages")]
        public virtual ICollection<Language>? SupportedLanguages { get; set; }

        [Display(Name = "DLC Images")]
        public virtual ICollection<DLCImage>? DLCImages { get; set; }

        [Display(Name = "Average Rating")]
        public double? AverageRating { get; set; }

        [Display(Name = "Trailer URL")]
        [DataType(DataType.Url)]
        public string? TrailerUrl { get; set; }

        public int? DLCImageId { get; set; }

        [ForeignKey("DLCImageId")]
        public virtual DLCImage? DLCImage { get; set; }
    }
}
