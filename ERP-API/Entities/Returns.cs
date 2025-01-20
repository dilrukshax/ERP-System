using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Returns
    {
        [Key]
        public int ReturnId { get; set; }

        [Required]
        public int OrderLineId { get; set; }

        [Required]
        public int ReturnQuantity { get; set; }

        [MaxLength(500)]
        public string ReturnReason { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }
    }
}
