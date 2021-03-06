﻿using RabookShelf.Models;
using System.Data.Entity;
using System.Collections;

namespace RabookShelf.Data
{
    public class Context : DbContext  
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
       

        public Context()
        {           
            Database.SetInitializer(new DatabaseInitializer());
        }

    }
}