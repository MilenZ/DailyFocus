using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public bool IsCompleted { get; set; }
        //public TaskPriority Priority { get; set; }
        public string UserId { get; set; } = null!;
    }
}
