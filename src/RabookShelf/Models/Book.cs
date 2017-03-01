﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RabookShelf.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public BookType BookType { get; set; }
        public bool Favorite { get; set; }
        public int Id { get; set; }

        public string DisplayText
        {
            get
            {
                return Title + ", by " + Author.FirstName + Author.LastName;
            }
        }
  
    }
}