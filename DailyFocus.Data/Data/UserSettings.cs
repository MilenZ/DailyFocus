using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyFocus.Data.Data
{
    public class UserSettings
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        public Guid SessionPresetId { get; set; }

        [ForeignKey(nameof(SessionPresetId))]
        public SessionPreset SessionPreset { get; set; } = null!;

        //public bool EnableSoundNotifications { get; set; }
        //public bool DarkModeEnabled { get; set; }
        //public int PreferredStartHour { get; set; }
        public int GoalSessionsPerDay { get; set; } = 4;
    }
}
