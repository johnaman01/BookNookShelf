using RabookShelf.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RabookShelf.Data
{
    internal class DatabaseInitializer : DropCreateIfModelChanges<Context>
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
        }
    }
}