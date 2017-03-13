using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RabookShelf.Models
{
    public class Book
    {
        public Book()
        {
            Authors = new List<AuthorBook>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
       
        public bool Fiction { get; set; }
        //would rather a Genre
        public BookSize BookSize { get; set; }
        public BookType BookType { get; set; }     
        public bool Favorite { get; set; }

        public ICollection<AuthorBook> Authors { get; set; }
        //nav to author

        public void AddAuthor(Author author)
        {
            Authors.Add(new AuthorBook()
            {
                Author = author
            });
        }

        //public string DisplayText
        //{
        //    get
        //    {
        //        return "\"" + Title + "\"" + ", by " + Author.FirstName + " " + Author.LastName;
        //    }
        //}
  
    }
}