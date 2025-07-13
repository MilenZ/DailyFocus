namespace DailyFocus.Infrastructure.Data
{
    public class TaskItemTag
    {
        public Guid TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; } = null!;
        public Guid TagId { get; set; }
        public Tag Tag { get; set; } = null!;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
