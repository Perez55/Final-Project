using System;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? CompleteDate { get; set; }

        [Required(ErrorMessage = "Please select a genre.")]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}