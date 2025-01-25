using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Vendors
    {
        [Key]
        public int VendorId { get; set; }

        [Required, MaxLength(100)]
        public string? ContactName { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string? Email { get; set; }

        [Required, Phone, MaxLength(20)]
        public string? Phone { get; set; }

        [Required, MaxLength(200)]
        public string? Address { get; set; }

        [Required, MaxLength(50)]
        public string? Country { get; set; }

        [Required, MaxLength(50)]
        public string? Status { get; set; }
    }
}
