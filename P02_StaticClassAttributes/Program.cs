// Static Attributes    = Variables shared across ALL instances of a class
//                        Value is stored in one place in memory
//                        If one object changes it, it changes for everyone

namespace P02_StaticClassAttributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Song.SongCount);
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.SongCount);
            Song kashmir = new Song("Kashmir", "Led Zepelin", 150);
            Console.WriteLine(Song.SongCount);
            Console.WriteLine(holiday.Title + " " + holiday.Artist + " " + holiday.DurationSec);
            Console.WriteLine(Song.SongCount);
            Console.WriteLine(kashmir.Title + " " + kashmir.Artist + " " + kashmir.DurationSec);
            Console.WriteLine(Song.SongCount);
        }
    }

    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int DurationSec { get; set; }
        // Static attribute to keep track of the number of Song instances
        public static int SongCount { get; set; } = 0;
        public Song(string title, string artist, int durationSec)
        {
            Title = title;
            Artist = artist;
            DurationSec = durationSec;
            SongCount++;
        }
    }
}
