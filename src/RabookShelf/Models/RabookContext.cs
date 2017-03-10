using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RabookShelf.Models
{
    public class RabookContext : DbContext  
    {
        public DbSet Book { get; set; }
        public DbSet Author { get; set; }
        public DbSet BookSize { get; set; }
        public DbSet BookType { get; set; }
        //public DbSet MyProperty { get; set; }
    }
}