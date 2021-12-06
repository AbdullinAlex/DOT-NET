using Microsoft.EntityFrameworkCore;

namespace Abdullin08.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Models.Student> Students { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
