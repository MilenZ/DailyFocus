using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Infrastructure.Data
{
    public class TaskItem
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public DateOnly DateAssignment { get; set; }

        public int SessionsCount { get; set; }

        public bool IsCompleted { get; set; }

        public TaskPriority Priority { get; set; }


        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}

/*
Id	uniqueidentifier (GUID)	Уникален идентификатор
Title	nvarchar(MAX)	Заглавие на задачата
Description	nvarchar(MAX)	Описание (опционално)
CreatedOn	datetime	Дата на създаване
IsCompleted	bit	Завършена ли е
Priority	nvarchar(20)	Enum: Low, Medium, High
UserId	nvarchar(450)	Връзка към потребителя
 * */