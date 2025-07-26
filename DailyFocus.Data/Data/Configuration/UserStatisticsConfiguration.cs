using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DailyFocus.Data.Data.Configuration
{
    public class UserStatisticsConfiguration : IEntityTypeConfiguration<UserStatistics>
    {
        public void Configure(EntityTypeBuilder<UserStatistics> entity)
        {
            entity
                .HasOne(us => us.User)
                .WithMany()
                .HasForeignKey(us => us.UserId);

            entity
                .Property(us => us.TotalTasksCreated);

            entity
                .Property(us => us.TotalTasksCompleted);

            entity
                .Property(us => us.TotalSessionsCount);

            entity
                .Property(us => us.TotalTimeSpent)
                .HasConversion(
                    v => v.Ticks,
                    v => TimeSpan.FromTicks(v))
                .IsRequired();

            entity
                .Property(us => us.LastActiveDate)
                .HasColumnType("datetime2")
                .HasDefaultValueSql("GETUTCDATE()")
                .HasConversion(
                    v => v.ToString("dd-MM-yyyy HH:mm:ss"),
                    v => DateTime.ParseExact(v, "dd-MM-yyyy HH:mm:ss", null))
                .IsRequired();
        }
    }
}
