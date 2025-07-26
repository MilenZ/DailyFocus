using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DailyFocus.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<SessionPreset> SessionPresets { get; set; } = null!;
        public virtual DbSet<Sessions> Sessions { get; set; } = null!;
        public virtual DbSet<SupportMessage> SupportMessages { get; set; } = null!;
        //public virtual DbSet<IdentityUser> Users { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<TaskComment> TaskComments { get; set; } = null!;
        public virtual DbSet<TaskItemTag> TaskItemTags { get; set; } = null!;
        public virtual DbSet<TaskItem> TaskItems { get; set; } = null!;
        public virtual DbSet<UserSettings> UserSettings { get; set; } = null!;
        public virtual DbSet<UserStatistics> UserStatistics { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
