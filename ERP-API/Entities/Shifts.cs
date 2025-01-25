using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Shifts
    {
        [Key]
        public int ShiftId { get; set; }

        [Required, MaxLength(100)]
        public string? ShiftName { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        [MaxLength(200)]
        public string? AssignedTo { get; set; }
    }
}
