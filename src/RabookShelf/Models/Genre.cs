namespace RabookShelf.Models
{
    public class Genre
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

        public int Id { get; set; }
        public string Name { get; set; }

    }
}