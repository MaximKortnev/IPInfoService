using IPInfoService.Models;
using Microsoft.EntityFrameworkCore;

namespace IPInfoService
{
    public class DatabaseContext : DbContext
    {
        public DbSet<RequestHistory> RequestHistories { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            Database.Migrate();
        }
    }
}
