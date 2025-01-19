using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class CartItems
    {
        [Key]
        public int CartId { get; set; }

        [Required]
        public int EcommProductId { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
}
