using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class JournalEntries
    {
        [Key]
        public int JournalId { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public int ApprovedBy { get; set; }
    }
}
