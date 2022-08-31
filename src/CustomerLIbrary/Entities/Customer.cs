using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerLIbrary.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        public decimal TotalPurchasesAmount { get; set; }
    }
}
