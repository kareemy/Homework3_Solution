using System;

namespace Homework3
{
    // Prep Work: Create Game Entity Class
    public class Game
    {
        public int GameId {get; set;} // Primary Key
        public string Name {get; set;} = string.Empty;
        public string Developer {get; set;} = string.Empty;
        public string Genre {get; set;} = string.Empty;
        public int PeakPlayers {get; set;}
        public decimal Price {get; set;} // Price is decimal data type
        public DateTime ReleaseDate {get; set;}
        public string ReviewScore {get; set;} = string.Empty;

        // Question 0: Create ToString() method that formats how we will print out each game to the console
        // I suggest something like: gameName, genre, # of peak players
        // for example "Counter-Strike: Global Offensive, Action, 620,408 peak players
        // Use format specifiers to change formatting of PeakPlayers - {PeakPlayers:N0}
        public override string ToString()
        {
            return $"{Name}, {Genre}, {PeakPlayers:N0} peak players";
        }
    }
}