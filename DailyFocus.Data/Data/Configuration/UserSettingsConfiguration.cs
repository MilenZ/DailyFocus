using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DailyFocus.Data.Data.Configuration
{
    public class UserSettingsConfiguration : IEntityTypeConfiguration<UserSettings>
    {
        public void Configure(EntityTypeBuilder<UserSettings> entity)
        {
            entity.HasKey(us => us.Id);

            entity.HasOne(us => us.User)
                .WithMany()
                .HasForeignKey(us => us.UserId);

            entity
                .HasOne(us => us.SessionPreset)
                .WithMany()
                .HasForeignKey(us => us.SessionPresetId);

            entity.Property(us => us.GoalSessionsPerDay);
        }
    }
}
