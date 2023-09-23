using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Product;

namespace backend.Models.Product
{
    public class GameLanguage
    {
        public int GameId { get; set; }
        public Game? Game { get; set; }

        public int LanguageId { get; set; }
        public Language? Language { get; set; }
        
    }
}