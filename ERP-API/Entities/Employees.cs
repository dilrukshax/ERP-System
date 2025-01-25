using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Employees
    {
        [Key]
        public int EmpId { get; set; }

        [Required, MaxLength(100)]
        public string? FirstName { get; set; }

        [Required, MaxLength(100)]
        public string? LastName { get; set; }

        [Required, MaxLength(100)]
        public string? Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required, MaxLength(20)]
        public string? Phone { get; set; }

        [Required, MaxLength(200)]
        public string? Address { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required, MaxLength(50)]
        public string? JobTitle { get; set; }

        [Required, MaxLength(100)]
        public string? Role { get; set; }

        [Required, MaxLength(100)]
        public string? Department { get; set; }

        [Required, MaxLength(50)]
        public string? Status { get; set; }
    }
}
