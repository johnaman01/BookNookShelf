using RabookShelf.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

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
    }
}