using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAppBackend.Models
{
        public enum CardType
        {
            Visa,
            MasterCard,
            Amex,
            Discover
        }

        public class PaymentMethod
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            public string? Name { get; set; }

            public CardType? CardType { get; set; }

            [StringLength(4)]
            public string? CardLastFourDigits { get; set; }

            [DataType(DataType.Date)]
            public DateTime? CardExpirationDate { get; set; }

            [StringLength(50)]
            public string? BankName { get; set; }

        }
}