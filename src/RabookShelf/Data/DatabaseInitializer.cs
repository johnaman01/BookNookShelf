using RabookShelf.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace RabookShelf.Data
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
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
                Author = julia,
                Title = "Some Book"
            }; 
            context.Books.Add(book1);

            var book2 = new Book()
            {
                Author = me,
                Title = "Another One"
            };
            context.Books.Add(book2);

            var genres = new List<Genre>()
            {
                new Genre(Genre.GenreName.Fiction),
                new Genre(Genre.GenreName.NonFiction),
                new Genre(Genre.GenreName.SciFi),
                new Genre(Genre.GenreName.Fantasy),
                new Genre(Genre.GenreName.Philosophy),
                new Genre(Genre.GenreName.SelfHelp)
            };
            context.Genres.Add(genres);

            context.SaveChanges();
        }
    }
}