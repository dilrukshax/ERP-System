using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required, MaxLength(50)]
        public string? Status { get; set; }

        [Required]
        public int CreatedBy { get; set; }
    }
}
