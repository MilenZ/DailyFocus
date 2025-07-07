using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Infrastructure.Data
{
    public class Sessions
    {
        [Key]
        public int Id { get; set; }

        public Guid TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; } = null!;

        [Required]
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public DateTime? EndedAt { get; set; }

        public SessionStatus Status { get; set; } = SessionStatus.Active;
    }
}
