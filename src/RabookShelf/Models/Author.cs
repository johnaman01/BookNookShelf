using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RabookShelf.Models
{
    public class Author
    {
        public Author()
        {
            Books = new List<AuthorBook>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        //public string Pseudonym { get; set; }
        //public string Nationality { get; set; }
        //public string Gender { get; set; }
        //make an enum?

        public ICollection<AuthorBook> Books { get; set; }
        //nav to book     
    }
}