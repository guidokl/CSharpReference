// Getters & Setters    = Properties that control access to private fields (Encapsulation)
//                        get = read the value, set = write/assign the value
//                        Allows validation logic before saving data

namespace P03_GettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "PG-13");
            Movie shrek = new Movie("Shrek", "Dog");

            Console.WriteLine("--- Initial Values ---");
            Console.WriteLine($"{avengers.Title} is rated {avengers.Rating}");
            Console.WriteLine($"{shrek.Title} is rated {shrek.Rating}");

            Console.WriteLine("\n--- Updating Ratings ---");

            avengers.Rating = "R";
            Console.WriteLine($"Avengers is now: {avengers.Rating}");

            shrek.Rating = "Cat";
            Console.WriteLine($"Shrek is now: {shrek.Rating}");

            // Direct Access is Forbidden
            // avengers._rating = "G"; 
            /* ERROR: 'Movie._rating' is inaccessible due to its protection level
               Because _rating is 'private', only code INSIDE the Movie class 
               can touch it. The Main method is in the Program class, so it 
               MUST go through the public property 'Rating'.
            */

            Console.ReadLine();
        }
    }

    public class Movie
    {
        public string Title { get; set; }  // Auto-implemented property

        private string _rating = "NR";  // Backing field with default value

        public string Rating
        {
            get => _rating;
            set
            {
                if (value is "G" or "PG" or "PG-13" or "R" or "NR")
                {
                    _rating = value;
                }
                else
                {
                    _rating = "NR";
                }
            }
        }

        public Movie(string title, string rating)
        {
            Title = title;
            Rating = rating;
        }
    }
}