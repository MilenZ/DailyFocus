using static DailyFocus.GCommon.ValidationConstants.SupportMessage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Infrastructure.Data.Configuration
{
    public class SupportMessageConfiguration : IEntityTypeConfiguration<SupportMessage>
    {
        public void Configure(EntityTypeBuilder<SupportMessage> entity)
        {
            entity.HasKey(sm => sm.Id);

            entity.HasOne(sm => sm.User) 
                .WithMany() 
                .HasForeignKey(sm => sm.UserId); 

            entity.Property(sm => sm.Subject)
                .IsRequired()
                .HasMaxLength(MaxSubjectLength);

            entity.Property(sm => sm.Message)
                .IsRequired()
                .HasMaxLength(MaxMessageLength);

            entity.Property(sm => sm.CreatedOn)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()"); 

            entity.Property(sm => sm.IsResolved)
                .IsRequired()
                .HasDefaultValue(false); 
        }
    }
}
