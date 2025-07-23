using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static DailyFocus.GCommon.ValidationConstants.TaskItemTag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Infrastructure.Data.Configuration
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
