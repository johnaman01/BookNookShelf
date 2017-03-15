using RabookShelf.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RabookShelf.Data
{
    public class Repository
    {
        public static Context GetContext()
        {
            var context = new Context();
            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }
        public static IList<Book> GetBooks()
        {
            using (Context context = GetContext())
            {
                return context.Books
                    .OrderBy(b => b.Title)
                    .ToList();
            }
        }
        //TODO
        //<Add a AddBook method>
        //
        public static void AddBook(Book book)
        {
            using (Context context = GetContext())
            {
                // Get the next available entry ID.
                int nextAvailableEntryId = context.Books
                                           .Max(b => b.Id) + 1;

                book.Id = nextAvailableEntryId;

                context.Books.Add(book);
                context.SaveChanges();
            }
        }
    }
}