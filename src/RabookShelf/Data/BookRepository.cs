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
                Favorite = false,
                Id = 1
            }
        };
        //TODO Add a GetBook method...not to mention other methods to fulfill CRUD requirements
        public Book GetABook(int id)
        {
            Book bookToReturn = null;
            foreach (var book in _books)
            {
                if (book.Id == id)
                {
                    bookToReturn = book;
                    break;
                }
            }
            return bookToReturn;
        }
    }
}