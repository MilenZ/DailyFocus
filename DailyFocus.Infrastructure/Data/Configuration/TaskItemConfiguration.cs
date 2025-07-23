using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static DailyFocus.GCommon.ValidationConstants.TaskItem;

namespace DailyFocus.Infrastructure.Data.Configuration
{
    public class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> entity)
        {
            entity.HasKey(t => t.Id);

            entity.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(MaxTitleLength);

            entity
                .Property(t => t.Description)
                .HasMaxLength(MaxDescriptionLength);

            entity
                .Property(t => t.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETUTCDATE()");

            entity
                .Property(t => t.DateAssignment)
                .HasColumnType("date")
                .HasConversion(
                    v => v.ToString(DateAssignmentFormat),
                    v => DateOnly.ParseExact(v, DateAssignmentFormat));

            entity
                .Property(t => t.SessionsCount)
                .IsRequired();

            entity
                .Property(t => t.IsCompleted)
                .IsRequired();

            entity
                .HasOne(t => t.Category)
                .WithMany()
                .HasForeignKey(t => t.CategoryId);

            entity.HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId);
        }
    }
}
