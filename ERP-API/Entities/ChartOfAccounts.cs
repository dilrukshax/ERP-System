using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class ChartOfAccounts
    {
        [Key]
        public int AccountId { get; set; }

        [Required, MaxLength(50)]
        public string AccountCode { get; set; }

        [Required, MaxLength(200)]
        public string AccountName { get; set; }

        [Required, MaxLength(50)]
        public string AccountType { get; set; }

        public int? ParentAccountId { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
