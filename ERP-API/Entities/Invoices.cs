using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Invoices
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required, MaxLength(50)]
        public string? Status { get; set; }

        [Required]
        public int CreatedBy { get; set; }
    }
}
