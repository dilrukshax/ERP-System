using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Accounts
    {
        [Key]
        public int AccountId { get; set; }

        [Required, MaxLength(200)]
        public string? AccountName { get; set; }

        [Required, MaxLength(100)]
        public string? AccountOwner { get; set; }

        [Required, MaxLength(50)]
        public string? Status { get; set; }
    }
}
