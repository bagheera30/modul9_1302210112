using modul9_1302210112.Controllers;

namespace modul9_1302210112
{
    public class movie
    {
        public static List<movie> Movies = new List<movie>()
        {
            new movie() { title = "The Shawshank Redemption", director = "Frank Darabont", description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", star = new List<string>(){  "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" } },
            new movie() { title = "The Godfather", director = "Francis Ford Coppola", description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", star = new List<string>(){ "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" } },
            new movie() { title = "The Dark Knight", director = "Christopher Nolan", description = "TWhen the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", star = new List<string>(){ "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" } },
            new movie() { title = "The Lord of the Rings: The Return of the King", director = "Peter Jackson", description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", star = new List<string>(){ "Elijah Wood", "Viggo Mortensen", "Ian McKellen", "Orlando Bloom" } }
        };
        public string title { get; set; }
        public string director { get; set; }
        public List<string> star{ get; set;}
        public string description { get; set; }
        public movie() { }
    }
}
