using System.ComponentModel.DataAnnotations;

namespace CustomerLIbrary.Entities
{
    public class Notes
    {
        public int NoteId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Note { get; set; }
    }
}
