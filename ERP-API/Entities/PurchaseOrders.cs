using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class PurchaseOrders
    {
        [Key]
        public int PoId { get; set; }

        [Required]
        public int VendorId { get; set; }

        [Required]
        public int PrId { get; set; }

        [Required]
        public DateTime PoDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required, MaxLength(50)]
        public string? Status { get; set; }

        [Required]
        public int CreatedBy { get; set; }
    }
}
