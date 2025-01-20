using System.ComponentModel.DataAnnotations;

namespace ERP_API.Entities
{
    public class ProjectTasks
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required, MaxLength(200)]
        public string TaskName { get; set; }

        [Required]
        public int AssignedTo { get; set; }
    }
}
