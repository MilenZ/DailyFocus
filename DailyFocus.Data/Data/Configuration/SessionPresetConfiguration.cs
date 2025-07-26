using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DailyFocus.GCommon.ValidationConstants.SessionPreset;

namespace DailyFocus.Data.Data.Configuration
{
    public class SessionPresetConfiguration : IEntityTypeConfiguration<SessionPreset>
    {
        public void Configure(EntityTypeBuilder<SessionPreset> entity)
        {
            entity
                .HasKey(s => s.Id);

            entity
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            entity
                .Property(s => s.WorkMinutes)
                .IsRequired();

            entity
                .Property(s => s.ShortBreakMinutes)
                .IsRequired();

            entity
                .Property(s => s.LongBreakMinutes)
                .IsRequired();

            entity
                .Property(s => s.SessionsBeforeLongBreak)
                .IsRequired();

            entity.
                Property(s => s.IsPublic)
                .IsRequired();

            entity
                .Property(s => s.CreatedBy)
                .IsRequired();
        }
    }
}


/*
 * WorkMinutes
 * ShortBreakMinutes
 * LongBreakMinutes
 * SessionsBeforeLongBreak
 * IsPublic
 * CreatedBy
 */