using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RabookShelf.Models
{
    public class Book
    {
        public enum GenreName
        {
            Fiction = 1,
            NonFiction = 2,
            SciFi = 3,
            Fantasy = 4,
            Philosophy = 5,
            SelfHelp = 6
        }

        public Book()
        {
        }

        public Book(int id, string title, Author author, GenreName genre = GenreName.Fiction, 
            string description = null)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Description = description;
        }

        public int Id { get; set; }

        public string Title { get; set; }
        
        [MaxLength(50, ErrorMessage = "Only 50 characters, please, lest you're writing a novel of your own!")]
        public string Description { get; set; }
        
        public Author Author { get; set; }
        //nav to author

            //Add author method here
     
        public string BookDisplayText
        {
            get
            {
                return "\"" + Title + "\"";
            }
        }

        public GenreName Genre { get; set; }
    }
}