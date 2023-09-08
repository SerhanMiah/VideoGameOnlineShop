using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameAppBackend.Models;

namespace backend.Models.Product
{
    public class GameGameTag
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int GameTagId { get; set; }
        public GameTag GameTag { get; set; }
        
    }
}