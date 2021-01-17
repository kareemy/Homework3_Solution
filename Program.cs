using System;
using System.Collections.Generic;
// You need to add another using directive for LINQ. Put it here. Don't forget!

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prep Work: Copy and Paste list of data
            List<Game> games = new List<Game> {
                new Game {Name = "Counter-Strike: Global Offensive", Developer = "Valve", Genre = "Action", PeakPlayers = 620408, Price = 0.00M, ReleaseDate = DateTime.Parse("8/21/2012"), ReviewScore = "Very Positive"},
                new Game {Name = "Dota 2", Developer = "Valve", Genre = "Action", PeakPlayers = 840712, Price = 0.00M, ReleaseDate = DateTime.Parse("7/9/2013"), ReviewScore = "Very Positive"},
                new Game {Name = "PLAYERUNKNOWN'S BATTLEGROUNDS", Developer = "PUBG Corporation", Genre = "Action", PeakPlayers = 935918, Price = 29.99M, ReleaseDate = DateTime.Parse("12/21/2017"), ReviewScore = "Mixed"},
                new Game {Name = "Tom Clancy's Rainbow Six Siege", Developer = "Ubisoft", Genre = "Action", PeakPlayers = 137686, Price = 39.99M, ReleaseDate = DateTime.Parse("12/1/2015"), ReviewScore = "Very Positive"},
                new Game {Name = "Grand Theft Auto V", Developer = "Rockstar Games", Genre = "Action", PeakPlayers = 89756, Price = 29.99M, ReleaseDate = DateTime.Parse("4/14/2015"), ReviewScore = "Mixed"},
                new Game {Name = "RESIDENT EVIL 2 / BIOHAZARD RE:2", Developer = "CAPCOM Co., Ltd.", Genre = "Action", PeakPlayers = 74241, Price = 59.99M, ReleaseDate = DateTime.Parse("1/24/2019"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "Warframe", Developer = "Digital Extremes", Genre = "Action", PeakPlayers = 79181, Price = 0.0M, ReleaseDate = DateTime.Parse("3/25/2013"), ReviewScore = "Very Positive"},
                new Game {Name = "Rust", Developer = "Facepunch Studios", Genre = "Action", PeakPlayers = 64788, Price = 34.99M, ReleaseDate = DateTime.Parse("2/8/2018"), ReviewScore = "Very Positive"},
                new Game {Name = "Football Manager 2019", Developer = "Sports Interactive", Genre = "Simulation", PeakPlayers = 64139, Price = 49.99M, ReleaseDate = DateTime.Parse("11/2/2018"), ReviewScore = "Mostly Positive"},
                new Game {Name = "Team Fortress 2", Developer = "Valve", Genre = "Action", PeakPlayers = 62806, Price = 0.00M, ReleaseDate = DateTime.Parse("10/10/2007"), ReviewScore = "Very Positive"},
                new Game {Name = "MONSTER HUNTER: WORLD", Developer = "CAPCOM Co., Ltd.", Genre = "Action", PeakPlayers = 94455, Price = 59.99M, ReleaseDate = DateTime.Parse("8/9/2018"), ReviewScore = "Mixed"},
                new Game {Name = "Rocket League", Developer = "Psyonix, Inc.", Genre = "Racing", PeakPlayers = 55813, Price = 19.99M, ReleaseDate = DateTime.Parse("7/7/2015"), ReviewScore = "Very Positive"},
                new Game {Name = "Garry's Mod", Developer = "Facepunch Studios", Genre = "Simulation", PeakPlayers = 51230, Price = 9.99M, ReleaseDate = DateTime.Parse("11/29/2006"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "ARK: Survival Evolved", Developer = "Studio Wildcard", Genre = "Action", PeakPlayers = 51005, Price = 49.99M, ReleaseDate = DateTime.Parse("8/27/2017"), ReviewScore = "Mixed"},
                new Game {Name = "Path of Exile", Developer = "Grinding Gear Games", Genre = "Action", PeakPlayers = 39222, Price = 0.00M, ReleaseDate = DateTime.Parse("10/23/2013"), ReviewScore = "Very Positive"},
                new Game {Name = "Sid Meier's Civilization VI", Developer = "Firaxis Games", Genre = "Strategy", PeakPlayers = 38246, Price = 59.99M, ReleaseDate = DateTime.Parse("10/20/2016"), ReviewScore = "Mixed"},
                new Game {Name = "Terraria", Developer = "Re-Logic", Genre = "Action", PeakPlayers = 36420, Price = 9.99M, ReleaseDate = DateTime.Parse("5/16/2011"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "Sid Meier's Civilization V", Developer = "Firaxis Games", Genre = "Strategy", PeakPlayers = 35982, Price = 29.99M, ReleaseDate = DateTime.Parse("9/21/2010"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "Euro Truck Simulator 2", Developer = "SCS Software", Genre = "Simulation", PeakPlayers = 35153, Price = 19.99M, ReleaseDate = DateTime.Parse("10/12/2012"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "Ring of Elysium", Developer = "Aurora Software", Genre = "Action", PeakPlayers = 43183, Price = 0.00M, ReleaseDate = DateTime.Parse("9/19/2018"), ReviewScore = "Mostly Positive"},
            };

            // Question 1: Select the first game in the list.
            // What is the exact data type of this query result? Put your answer in README.md
        }
    }
}
