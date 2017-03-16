using System.Collections.Generic;

namespace RabookShelf.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }

        //public int GenreId { get; set; }
        public Genre Genre { get; set; }

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

    }
}