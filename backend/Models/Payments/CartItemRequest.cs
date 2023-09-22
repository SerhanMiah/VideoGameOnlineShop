using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameAppBackend.Models.Payments
{
    public class CartItemRequest
    {    
        public string? UserId { get; set; }
        public int GameId { get; set; }
        public int Quantity { get; set; }
    }
}