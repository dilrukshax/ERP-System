using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        [Required]
        public int EmpId { get; set; }

        [Required]
        public int ShiftId { get; set; }

        [Required]
        public DateTime ClockIn { get; set; }

        [Required]
        public DateTime ClockOut { get; set; }

        [Required]
        public decimal TotalHours { get; set; }
    }
}
