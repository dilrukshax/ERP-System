using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        [Required, MaxLength(100)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Phone, MaxLength(20)]
        public string Phone { get; set; }

        [EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; }
    }
}
