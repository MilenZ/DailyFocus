using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static DailyFocus.GCommon.ValidationConstants.TaskComment;

namespace DailyFocus.Infrastructure.Data.Configuration
{
    public class TaskCommentConfiguration : IEntityTypeConfiguration<TaskComment>
    {
        public void Configure(EntityTypeBuilder<TaskComment> entity)
        {
            entity.HasKey(tc => tc.TaskId);

            entity.Property(tc => tc.Comment)
                .IsRequired()
                .HasMaxLength(MaxCommentLength);
        }
    }
}
