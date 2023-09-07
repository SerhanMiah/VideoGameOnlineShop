using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public virtual Order? Order { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }

        public virtual Game? Game { get; set; }

        public int Quantity { get; set; }
    }
}