using RabookShelf.Models;
using System.Data.Entity;

namespace RabookShelf.Data
{
    internal class DatabaseInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            var me = new Author()
            {
                FirstName = "John",
                LastName = "A"
            };

            var julia = new Author()
            {
                FirstName = "Julienne",
                LastName = "Childs"
            };

            var book1 = new Book()
            {
                Title = "Some Book",
            };

            book1.AddAuthor(me);
            context.Books.Add(book1);

            var book2 = new Book()
            {
                Title = "Another One"
            };
            book2.AddAuthor(julia);
            context.Books.Add(book2);

            context.SaveChanges();
        }
    }
}