using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class JournalLines
    {
        [Key]
        public int LineId { get; set; }

        [Required]
        public int JournalId { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required]
        public decimal DebitAmount { get; set; }

        [Required]
        public decimal CreditAmount { get; set; }
    }
}
