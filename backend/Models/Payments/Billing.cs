using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VideoGameAppBackend.Models;

namespace backend.Models.Payments
{
public class Billing
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    public string Address { get; set; }


    [Required]
    public string City { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    public string ZipCode { get; set; }

    [Required, DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }

    [Required, DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    // Foreign Key for ApplicationUser
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual ApplicationUser User { get; set; }

    // Assuming each order will have its billing record
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();

}


}