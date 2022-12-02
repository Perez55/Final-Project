using System;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class BookViewModel
    {
        public BookViewModel()
        {
            CurrentBook = new Book();
        }
        public Filters Filters { get; set; }
        public List<Genre> Genres { get; set; }
        public Dictionary<string, string> ReadFilters { get; set; }
        public List<Book> Books { get; set; }
        public Book CurrentBook { get; set; } // used for Add
    }
}