using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyFocus.Infrastructure.Data
{
    public class Sessions
    {
        [Key]
        public int Id { get; set; }

        public Guid TaskItemId { get; set; }

        [ForeignKey(nameof(TaskItemId))]
        public virtual TaskItem TaskItem { get; set; } = null!;

        public string? UserId { get; set; } = null;

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public DateTime? EndedAt { get; set; }

        [Required]
        public SessionStatus Status { get; set; } = SessionStatus.Created;
    }
}
