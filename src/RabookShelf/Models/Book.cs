using System.Collections.Generic;

namespace RabookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Fiction { get; set; }
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