using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyFocus.Data.Data
{
    public class UserStatistics
    {
        [Required]
        public string UserId { get; set; } = null!;
        public int TotalTasksCreated { get; set; }
        public int TotalTasksCompleted { get; set; }
        public int TotalSessionsCount { get; set; }
        public TimeSpan TotalTimeSpent { get; set; }
        public DateTime LastActiveDate { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(UserId))]
        public virtual IdentityUser User { get; set; } = null!;
    }
}
