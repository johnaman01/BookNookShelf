using RabookShelf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RabookShelf.Data
{
    public class Context : DbContext  
    {
        //public Context()
        //{
        //    Database.SetInitializer(new DatabaseInitializer());
        //}

        public DbSet<Book> Books { get; set; }
        
        //public DbSet Book { get; set; }
        //public DbSet Author { get; set; }
        //public DbSet BookSize { get; set; }
        //public DbSet BookType { get; set; }
        //public DbSet MyProperty { get; set; }
    }
}