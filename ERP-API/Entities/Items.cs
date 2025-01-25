using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Items
    {
        [Key]
        public int ItemId { get; set; }

        [Required, MaxLength(200)]
        public string? ItemName { get; set; }

        [MaxLength(500)]
        public string? ItemDescription { get; set; }

        [Required]
        public decimal ItemPrice { get; set; }

        [Required, MaxLength(50)]
        public string? StockUnit { get; set; }
    }
}
