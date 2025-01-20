using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class PurchaseRequests
    {
        [Key]
        public int PrId { get; set; }

        [Required]
        public int RequestBy { get; set; }

        [Required]
        public DateTime RequestDate { get; set; }

        [Required, MaxLength(500)]
        public string Reason { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; }
    }
}
