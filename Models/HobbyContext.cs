// This will be the connection to the datbase
using Microsoft.EntityFrameworkCore;
namespace Final_Project.Models
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options)
        : base(options)

        { }
        public DbSet<Hobby> hobby { get; set; }
        public DbSet<User> user { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new HobbyConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());

        }

    }
}
