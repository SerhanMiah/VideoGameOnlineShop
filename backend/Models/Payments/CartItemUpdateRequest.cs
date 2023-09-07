using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameAppBackend.Models.Payments
{
    public class CartItemUpdateRequest
    {
        public int CartItemId { get; set; }
        public int NewQuantity { get; set; }
    }
}