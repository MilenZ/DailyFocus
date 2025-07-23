using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyFocus.Infrastructure.Data
{
    public class SessionPreset
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int WorkMinutes { get; set; } = 25; // Default to 25 minutes

        [Required]
        public int ShortBreakMinutes { get; set; } = 5; // Default to 5 minutes

        [Required]
        public int LongBreakMinutes { get; set; } = 15; // Default to 15 minutes

        [Required]
        public int SessionsBeforeLongBreak { get; set; } = 4; // Default to 4 sessions

        [Required]
        public bool IsPublic { get; set; } = true; // Default to public

        [Required]
        public string CreatedBy { get; set; } = null!; // Optional admin who created this preset

        [ForeignKey(nameof(CreatedBy))]
        public virtual  ApplicationUser User { get; set; } = null!;
    }
}

/*
Id	                    GUID (PK)	Уникален идентификатор
Name	                string	    Име на preset (напр. „Класически“)
WorkMinutes	            int	    Продължителност на работна сесия
ShortBreakMinutes	    int	    Кратка почивка
LongBreakMinutes	    int	    Дълга почивка
SessionsBeforeLongBreak	int	    Колко сесии преди дълга почивка
IsPublic	            bool	Дали preset-а е публичен за всички потребители
CreatedByAdminId	    string  (FK → ApplicationUser.Id)	Кой админ е създал preset-а (по избор)
*/