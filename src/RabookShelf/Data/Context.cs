using RabookShelf.Models;
using System.Data.Entity;

namespace RabookShelf.Data
{
    public class Context : DbContext  
    {      
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public Context()
        {           
            Database.SetInitializer(new DatabaseInitializer());
        }

    }
}