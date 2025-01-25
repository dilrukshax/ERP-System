using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class InventoryMovements
    {
        [Key]
        public int MoveId { get; set; }

        [Required]
        public int FromLocationId { get; set; }

        [Required]
        public int ToLocationId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required, MaxLength(50)]
        public string? MoveType { get; set; }

        [Required]
        public DateTime MovementDate { get; set; }
    }
}
