using Microsoft.EntityFrameworkCore;

namespace Millionaires.Models
{
    public class MillionairesContext : DbContext
    {
        public MillionairesContext(DbContextOptions<MillionairesContext> options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Level> Levels { get; set; }

    }
}
