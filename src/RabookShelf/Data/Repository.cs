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
                //attach book to context as Unmodified
                context.Books.Attach(book);
                //use form to change properties, ie state?
                context.Entry(book).State = System.Data.Entity.EntityState.Modified;               

                context.SaveChanges();
            }
        }
        //TODO
        //<Add an DeleteBook method>
        public static void Delete(int bookId)
        {
            using (Context context = GetContext())
            {
                var book = new Book() { Id = bookId };

                context.SaveChanges();
            }
        }
    }
}