using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace DAL.EF
{
    public class DemoContext : DbContext
    {
        public DemoContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                        
                    .UseSqlite("Data Source=Demo_EF.db")
                    .UseLoggerFactory(new LoggerFactory(
                        new[]
                        {
                            new DebugLoggerProvider(
                                (category, level) =>
                                    category == DbLoggerCategory.Database.Command.Name
                                    && level == LogLevel.Information
                            )
                        })
                    );
            }
        }
        public DbSet<Domain.Project> projects { get; set; }
    }
        
    
}