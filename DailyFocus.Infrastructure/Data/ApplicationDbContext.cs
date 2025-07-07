using DailyFocus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DailyFocus.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Domain.Entities.TaskItem> Tasks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
    }
}
