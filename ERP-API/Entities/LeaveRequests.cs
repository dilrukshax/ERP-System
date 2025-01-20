using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class LeaveRequests
    {
        [Key]
        public int LeaveId { get; set; }

        [Required]
        public int EmpId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [MaxLength(500)]
        public string Reason { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; }
    }
}
