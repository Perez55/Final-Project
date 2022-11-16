// This will be the connection to the datbase
using Microsoft.EntityFrameworkCore;
namespace Final_Project.Models
{ 
    public class HobbiesContext:DbContext {
        public HobbiesContext(DbContextOptions<HobbiesContext> options)
        :base(options)

        {}
    public DbSet<Hobbies> hobbies {get;set;}
    public DbSet<User> user {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {




    }

    }
 }
