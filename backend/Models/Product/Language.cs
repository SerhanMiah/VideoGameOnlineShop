using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Models.Product;

namespace VideoGameAppBackend.Models.Product
{
    public class Language
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Language Name")]
        public string? LanguageName { get; set; }

        public virtual ICollection<GameLanguage> GameLanguages { get; set; } = new List<GameLanguage>();

    }
}