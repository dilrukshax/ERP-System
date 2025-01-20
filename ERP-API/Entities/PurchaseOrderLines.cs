using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class PurchaseOrderLines
    {
        [Key]
        public int PoLineId { get; set; }

        [Required]
        public int PoId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
    }
}
