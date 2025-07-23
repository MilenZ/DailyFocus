using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyFocus.Infrastructure.Data
{
    public class TaskItemTag
    {
        [Required]
        public Guid TaskItemId { get; set; }

        [ForeignKey(nameof(TaskItemId))]
        public TaskItem TaskItem { get; set; } = null!;

        [Required]
        public Guid TagId { get; set; }

        [ForeignKey(nameof(TagId))]
        public Tag Tag { get; set; } = null!;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
