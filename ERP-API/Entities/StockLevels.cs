using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class StockLevels
    {
        [Key]
        public int StockId { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int QuantityOnHand { get; set; }

        [Required]
        public int ReorderPoint { get; set; }
    }
}
