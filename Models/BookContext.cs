
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "fantasy", Name = "Fantasy" },
                new Genre { GenreId = "adventure", Name = "Adventure" },
                new Genre { GenreId = "mystery", Name = "Mystery" },
                new Genre { GenreId = "romance", Name = "Romance" },
                new Genre { GenreId = "thriller", Name = "Thriller" }
            );
        }
    }
}