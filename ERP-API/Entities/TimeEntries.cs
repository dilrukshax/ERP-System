using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class TimeEntries
    {
        [Key]
        public int TimeEntryId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public int TaskId { get; set; }

        [Required]
        public int EmpId { get; set; }

        [Required]
        public decimal HourWorked { get; set; }

        [Required]
        public bool Approved { get; set; }
    }
}
