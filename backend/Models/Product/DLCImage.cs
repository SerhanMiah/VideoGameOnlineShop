using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models.Product
{
    public class DLCImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        [DataType(DataType.Url)]
        public string? ImageUrl { get; set; }

        [Display(Name = "Image Caption")]
        public string? Caption { get; set; }

        [ForeignKey("DLC")]
        public int DLCId { get; set; }

        public virtual DLC? DLC { get; set; }
    }
}
