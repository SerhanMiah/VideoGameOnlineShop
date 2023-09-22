using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Product
{
    public class GameTag
    {
        [Key]
        public int TagId { get; set; }

        [Required, StringLength(100), Display(Name = "Tag Name")]
        public string? TagName { get; set; }

        public virtual ICollection<GameGameTag> GameGameTags { get; set; } = new List<GameGameTag>();
        
    }
}