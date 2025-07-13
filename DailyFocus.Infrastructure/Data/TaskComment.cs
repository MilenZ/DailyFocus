using System.ComponentModel.DataAnnotations;

namespace DailyFocus.Infrastructure.Data
{
    public class TaskComment
    {
        [Required]
        public Guid TaskId { get; set; }

        [Required]
        public string Comment { get; set; } = null!;
    }
}
