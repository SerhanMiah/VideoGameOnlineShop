using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoGameAppBackend.Models.Product
{
    public class AgeRating
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Rating { get; set; }

        public virtual ICollection<Game>? Games { get; set; }
    }
}
