using System.ComponentModel.DataAnnotations;

namespace DailyFocus.Infrastructure.Data
{
    public class SupportMessage
    {
        [Key]
        public string Id { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public string Subject { get; set; } = null!;

        [Required]
        public string Message{ get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsResolved { get; set; } = false;

    }
}
