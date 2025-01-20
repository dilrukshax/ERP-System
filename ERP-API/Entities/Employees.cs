using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Employees
    {
        [Key]
        public int EmpId { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required, MaxLength(100)]
        public string Role { get; set; }

        [Required, MaxLength(100)]
        public string Department { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; }
    }
}
