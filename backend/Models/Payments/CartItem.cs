using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models.Payments
{
    public class CartItem
    {
    [Key]
    public int Id { get; set; }

    [ForeignKey("Cart")]
    public int CartId { get; set; }

    public virtual Cart? Cart { get; set; }

    [ForeignKey("Game")]
    public int GameId { get; set; }

    public virtual Game? Game { get; set; }

    public int Quantity { get; set; }
    }
}