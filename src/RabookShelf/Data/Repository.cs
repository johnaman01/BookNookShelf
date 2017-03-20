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

        //GetBooks method
        public static IList<Book> GetBooks()
        {
            using (Context context = GetContext())
            {
                return context.Books
                    .OrderBy(b => b.Title)
                    .ToList();
            }
        }
        
        //GetABook method
        public static Book GetABook(int id)
        {
            using (Context context = GetContext())
            {
                Book book = context.Books
                .Where(b => b.Id == id)
                .SingleOrDefault();

                return book;
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
        //TODO
        //<Add an UpdateBook method>
        public static void UpdateBook(Book book)
        {
            using (Context context = GetContext())
            {
               
                Book bookToUp = context.Books.Find(book.Id);

                bookToUp.Title = book.Title;
                bookToUp.Author = book.Author;
                bookToUp.Genre = book.Genre;
                bookToUp.Description = book.Description;

                context.SaveChanges();

            }
        }
    }
}