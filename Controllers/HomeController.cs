using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReadingList.Models;

namespace ReadingList.Controllers
{
    public class HomeController : Controller
    {
        private BookContext context;
        public HomeController(BookContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            // load current filters and data needed for filter drop downs in ViewBag
            var filters = new Filters(id);
            BookViewModel model = new BookViewModel();
            model.Filters = filters;
            model.Genres = context.Genres.ToList();
            model.ReadFilters = Filters.ReadFilterValues;

            // get Book objects from database based on current filters
            IQueryable<Book> query = context.Books
                .Include(t => t.Genre);
            if (filters.HasGenre) {
                query = query.Where(t => t.GenreId == filters.GenreId);
            }
            if (filters.HasDue) {
                var today = DateTime.Today;
                if (filters.IsPast)
                    query = query.Where(t => t.CompleteDate < today);
                else if (filters.IsFuture)
                    query = query.Where(t => t.CompleteDate > today);
                else if (filters.IsToday)
                    query = query.Where(t => t.CompleteDate == today);
            }
            model.Books = query.OrderBy(t => t.CompleteDate).ToList();
            return View(model);
        }

        public IActionResult Add()
        {
            BookViewModel model = new BookViewModel();
            model.Genres = context.Genres.ToList();
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(model.CurrentBook);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                model.Genres = context.Genres.ToList();
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute]string id, string action, Book selected)
        {
            if (action == "delete")
            {
                context.Books.Remove(selected);
            }
            else if (action == "start")
            {
                selected = context.Books.Find(selected.Id);
                selected.StartDate = DateTime.Today;
                context.Books.Update(selected);
            }
            else if (action == "complete")
            {
                selected = context.Books.Find(selected.Id);
                selected.CompleteDate = DateTime.Today;
                context.Books.Update(selected);
            }
            context.SaveChanges();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}