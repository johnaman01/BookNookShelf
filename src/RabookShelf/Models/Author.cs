using System.Collections.Generic;

namespace RabookShelf.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        //public string Pseudonym { get; set; }
        //public string Nationality { get; set; }
        //public string Gender { get; set; }
        //make an enum?

        public ICollection<Book> Books { get; set; }
        //nav to book

    }
}