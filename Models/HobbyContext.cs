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
        public DbSet<Admin> admin { get; set; }
        public DbSet<About> about {get;set;}
        public DbSet<AdminHobby> AdminHobbies {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new HobbyConfig());
            modelBuilder.ApplyConfiguration(new AdminConfig());
            modelBuilder.ApplyConfiguration(new AdminHobbyConfig());
        }

    }
}
