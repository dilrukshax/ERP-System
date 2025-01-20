using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class OrderLines
    {
        [Key]
        public int OrderLineId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
    }
}
