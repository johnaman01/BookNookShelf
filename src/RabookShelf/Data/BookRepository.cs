using RabookShelf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RabookShelf.Data
{
    public class BookRepository
    {
        private static Book[] _books = new Book[]
        {
            new Book()
            {
                
                Title = "Some Book",

                Author = new Author()
                {
                    FirstName = "John",
                    LastName = "Amann",
                    Pseudonym = "Lovelace"
                },

                BookType = new BookType()
                {
                    HardCover = true
                },

                Favorite = false

            }
        };
    }
}