using System.Collections.Generic;

namespace ReadingList.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all";
            string[] filters = FilterString.Split('-');
            GenreId = filters[0];
            Due = filters[1];
        }
        public string FilterString { get; }
        public string GenreId { get; }
        public string Due { get; }

        public bool HasGenre => GenreId.ToLower() != "all";
        public bool HasDue => Due.ToLower() != "all";

        public static Dictionary<string, string> ReadFilterValues =>
            new Dictionary<string, string> {
                { "future", "Future" },
                { "past", "Past" },
                { "today", "Today" }
            };
        public bool IsPast => Due.ToLower() == "past";
        public bool IsFuture => Due.ToLower() == "future";
        public bool IsToday => Due.ToLower() == "today";
    }
}
