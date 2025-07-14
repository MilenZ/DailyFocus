using System.ComponentModel.DataAnnotations;

namespace DailyFocus.Infrastructure.Data
{
    /*
     * Tag will be used to label tasks with specific keywords or topics.  
     * It will be defined by the Admin of the application.
     */
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}

/*
Work        (Meeting, Emails, Project)
Deep Work   (Shallow Work, Creative)
Homme       (Errands, Finance)
Health      (Exercise, Meditation, Reading)
Today       (This week, Backlog)
Urgent      (Important, Optional)
*/