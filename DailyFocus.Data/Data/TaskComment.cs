using System.ComponentModel.DataAnnotations;

namespace DailyFocus.Data.Data
{
    public class TaskComment
    {
        [Required]
        public Guid TaskId { get; set; }

        [Required]
        public string Comment { get; set; } = null!;
    }
}
