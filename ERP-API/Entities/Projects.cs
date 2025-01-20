using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }

        [Required, MaxLength(200)]
        public string ProjectName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [MaxLength(200)]
        public string ProjectManager { get; set; }
    }
}
