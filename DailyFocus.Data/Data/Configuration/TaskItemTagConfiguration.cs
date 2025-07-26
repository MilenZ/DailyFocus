using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DailyFocus.Data.Data.Configuration
{
    public class TaskItemTagConfiguration : IEntityTypeConfiguration<TaskItemTag>
    {
        public void Configure(EntityTypeBuilder<TaskItemTag> entity)
        {
            entity.HasKey(ti => new { ti.TaskItemId, ti.TagId });

            entity
                .HasOne(ti => ti.TaskItem)
                .WithMany()
                .HasForeignKey(ti => ti.TaskItemId);

            entity
                .HasOne(ti => ti.Tag)
                .WithMany()
                .HasForeignKey(ti => ti.TagId);
        }
    }
}
