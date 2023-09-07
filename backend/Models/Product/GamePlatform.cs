using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameAppBackend.Models.Product
{
    public class GamePlatform
    {
        public int GameId { get; set; }
        public Game? Game { get; set; }

        public int PlatformId { get; set; }
        public Platform? Platform { get; set; }
        
    }
}