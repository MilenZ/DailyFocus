using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static DailyFocus.GCommon.ValidationConstants.Category;

namespace DailyFocus.Infrastructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            entity.Property(c => c.Color)
                .IsRequired()
                .HasMaxLength(MaxColorLength); // Assuming color is stored as a hex code (e.g., #FFFFFF)

            entity.Property(c => c.Description)
                .HasMaxLength(MaxDescriptionLength);
            
        }
    }
}
