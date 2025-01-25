using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class FixedAssets
    {
        [Key]
        public int AssetId { get; set; }

        [Required, MaxLength(200)]
        public string? AssetName { get; set; }

        [Required, MaxLength(100)]
        public string? AssetClass { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public decimal PurchasePrice { get; set; }

        [Required, MaxLength(100)]
        public string? DepreciationMethod { get; set; }

        [Required]
        public decimal SalvageValue { get; set; }

        [Required]
        public int UsefulLifeMonths { get; set; }

        [Required]
        public decimal CurrentBookValue { get; set; }
    }
}
