using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RabookShelf.Models
{
    //Going to Delete2
    public class AuthorBook
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        //payload properties below
        //public int MyProperty { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }
        //payload nav


    }
}