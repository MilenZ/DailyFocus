using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DailyFocus.Data.Data.Configuration
{
    public class SessionConfiguration : IEntityTypeConfiguration<Sessions>
    {
        public void Configure(EntityTypeBuilder<Sessions> entity)
        {
            entity.HasKey(s => s.Id);

            entity.Property(s => s.TaskItemId)
                .IsRequired();

            entity.HasOne(s => s.TaskItem);

            entity.HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId);

            entity.HasOne(s => s.User);

            entity.Property(s => s.StartedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()"); // Default to current UTC time 
            
            entity.Property(s => s.EndedAt);
            
            entity.Property(s => s.Status)
                .IsRequired()
                .HasConversion<string>(); // Assuming SessionStatus is an enum, convert it to string for storage
        }
    }
}


/*
 * Id
 * TaskItemId
 * UserId
 * StartedAt
 * EndedAt
 * Status 
 */