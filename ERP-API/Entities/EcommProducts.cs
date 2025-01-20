using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class EcommProducts
    {
        [Key]
        public int EcommProductId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required, MaxLength(500)]
        public string? ProductDescription { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Qty { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
