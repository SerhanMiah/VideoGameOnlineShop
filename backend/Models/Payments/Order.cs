using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models
{
    public enum OrderStatus
    {
        Placed,
        Approved,
        Shipped,
        Delivered,
        Cancelled
    }

    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? ApplicationUserId { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }

        public virtual ICollection<OrderItem>? OrderItems { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        [Required]
        [StringLength(200)]
        public string? ShippingAddress { get; set; }
    }
}