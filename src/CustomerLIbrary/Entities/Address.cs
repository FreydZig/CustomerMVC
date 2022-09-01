using System.ComponentModel.DataAnnotations;

namespace CustomerLIbrary.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(100)]
        public string AddressLine { get; set; }
        [StringLength(100)]
        public string AddressLine2 { get; set; }
        [StringLength(20)]
        public string AddressType { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(6)]
        [RegularExpression(@"[0-9]{6}")]
        public string PostalCode { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
    }
}
