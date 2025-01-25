using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Locations
    {
        [Key]
        public int LocationId { get; set; }

        [Required, MaxLength(100)]
        public string? LocationName { get; set; }

        [Required, MaxLength(50)]
        public string? LocationType { get; set; }
    }
}
