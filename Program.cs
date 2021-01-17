using System;
using System.Collections.Generic;
// You need to add another using directive for LINQ. Put it here. Don't forget!
using System.Linq;

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
            // The data type of this query is a Game object because the query returns just ONE result.
            Game gameOne = games.First();
            Console.WriteLine("Query 1: First Game");
            Console.WriteLine($"------------");
            Console.WriteLine(gameOne);
            Console.WriteLine($"------------\n");

            // Question 2: Select the first THREE games.
            // The data type of this query is a list of games because the query returns multiple results.
            // The exact data type is IEnumerable<Game>. IEnumberable<> is the data type used by LINQ when querying in-memory data stores like lists
            var query2 = games.Take(3);
            Console.WriteLine("Query 2: First THREE games");
            Console.WriteLine($"------------");
            foreach (Game g in query2)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine($"------------\n");

            // Question 3: Select the 3 games after the first 4 games
            // Use .Skip(4) to skip the first 4 games, then .Take(3) to give us the next three
            var query3 = games.Skip(4).Take(3);
            Console.WriteLine("Query 3: The 3 games after the first 4 games");
            Console.WriteLine($"------------");
            foreach (Game g in query3)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine($"------------\n");

            // Question 4: Select games with peak palyers over 100,000 in method syntax
            var query4 = games.Where(g => g.PeakPlayers > 100000);
            Console.WriteLine("Query 4 Method Syntax: Games with peak players over 100,000");
            Console.WriteLine($"------------");
            foreach (Game g in query4)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine($"------------\n");

            // Query Syntax
            var query4QS = from g in games
                            where g.PeakPlayers > 100000
                            select g;
            Console.WriteLine("Query 4 Query Syntax: Games with peak players over 100,000");
            Console.WriteLine($"------------");
            foreach (Game g in query4QS)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine($"------------\n");

            // Question 5: Select games with peak players over 100,000 and a release date before January 1, 2013
            var query5 = games.Where(g => g.PeakPlayers > 100000).Where(g => g.ReleaseDate < DateTime.Parse("1/1/2013"));            
            Console.WriteLine("Query 5 Method Syntax: Games with peak players over 100,000 and release date before 1/1/2013");
            Console.WriteLine($"------------");
            foreach (Game g in query5)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine($"------------\n");      

            // Query Syntax
            var query5QS = from g in games
                            where g.PeakPlayers > 100000
                            where g.ReleaseDate < DateTime.Parse("1/1/2013")
                            select g;
            Console.WriteLine("Query 5 Query Syntax: Games with peak players over 100,000 and release date before 1/1/2013");
            Console.WriteLine($"------------");
            foreach (Game g in query5QS)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine($"------------\n");     

            // Question 6: Select the first game released prior to 1/1/2006 using .FirstOrDefault()
            var query6 = games.Where(g => g.ReleaseDate < DateTime.Parse("1/1/2006")).FirstOrDefault();
            if (query6 == null)
            {
                Console.WriteLine("Query 6 .FirstOrDefault(): No top 20 games released before 1/1/2006");
            }
            else
            {
                Console.WriteLine($"Query 6 .FirstOrDefault(): {query6}");
            }

            // Question 7: Select the first game released prior to 1/1/2006 using .First()
            try 
            {
                var query7 = games.Where(g => g.ReleaseDate < DateTime.Parse("1/1/2006")).First();
                Console.WriteLine($"Query 7 .First(): {query7}");
            }
            catch
            {
                Console.WriteLine("Query 7 .First(): No top 20 games released before 1/1/2006\n");
            }

            // Question 8: Select the game named Rust using .Single()
            var query8 = games.Where(g => g.Name == "Rust").Single();
            Console.WriteLine("Query 8: Select Rust");
            Console.WriteLine($"------------");
            Console.WriteLine(query8);
            Console.WriteLine($"------------\n");

            // Question 9: Select all games ordered by release date oldest to newest.
            var query9 = games.OrderBy(g => g.ReleaseDate);
            Console.WriteLine("Query 9 Method Syntax: Games ordered by release date oldest to newest");
            Console.WriteLine($"------------");
            foreach (Game g in query9)
            {
                Console.WriteLine($"{g}, {g.ReleaseDate.ToShortDateString()}");
            }
            Console.WriteLine($"------------\n");    

            // Query Syntax
            var query9QS = from g in games
                            orderby g.ReleaseDate
                            select g;

            // Question 10: Select all games ordered by genre A-Z and then peak players highest to lowest
            var query10 = games.OrderBy(g => g.Genre).ThenByDescending(g => g.PeakPlayers);
            Console.WriteLine("Query 10 Method Syntax: Games ordered by genre A-Z and then peak players highest to lowest");
            Console.WriteLine($"------------");
            foreach (Game g in query10)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine($"------------\n");    

            // Query Syntax
            var query10QS = from g in games
                orderby g.Genre, g.PeakPlayers descending
                select g;

            // Question 11: Select just the game name of all games that are free
            var query11 = games.Where(g => g.Price == 0.00M).Select(g => g.Name);
            Console.WriteLine($"Query 11 Method Syntax: Games that are free - just the game name. {query11.Count()} results.");
            Console.WriteLine($"------------");
            foreach (string gameName in query11)
            {
                Console.WriteLine(gameName);
            }
            Console.WriteLine($"------------\n");  
            
            // Query Syntax
            var query11QS = from g in games
                where g.Price == 0.00M
                select g.Name;
            
            // Question 12: Select the game name and peak players of all games that are free
            // The data type is an anonymous type. We must the var keyword.
            // This is because we are creating a new type of object on the fly that contains just the game name and peak players
            var query12 = games.Where(g => g.Price == 0.00M).Select(g => new {g.Name, g.PeakPlayers});
            Console.WriteLine($"Query 12 Method Syntax: Games that are free - game name and peak players. {query12.Count()} results.");
            Console.WriteLine($"------------");
            foreach (var g in query12)
            {
                Console.WriteLine($"{g.Name}, {g.PeakPlayers:N0}");
            }
            Console.WriteLine($"------------\n");  

            // Query Syntax
            var query12QS = from g in games
                where g.Price == 0.00M
                select new {g.Name, g.PeakPlayers};

            // Question 13: Group the games by developer. Print the results to the console in a similar format to below. 
            var query13groupBy = games.GroupBy(g => g.Developer).OrderByDescending(g => g.Count());
            Console.WriteLine("---Games grouped by developer---");
            foreach (var group in query13groupBy)
            {
                Console.WriteLine($"{group.Key} - {group.Count()} game(s)");
                foreach (var game in group)
                {
                    Console.WriteLine("\t" + game);
                }
            }
            Console.WriteLine("---\n");

            var query13groupByQS = from g in games
                    group g by g.Developer into devGroup
                    orderby devGroup.Count() descending
                    select devGroup;
            /* 
            foreach (var group in query13groupByQS)
            {
                Console.WriteLine($"{group.Key} - {group.Count()} game(s)");
                foreach (var game in group)
                {
                    Console.WriteLine("\t" + game);
                }
            }
            */

            // Question 14: Select the game with the most peak players (just in Method Syntax).
            var query14 = games.OrderByDescending(g => g.PeakPlayers).First();
            Console.WriteLine("Game with most players: " + query14);

            var query14a = games.Where(g => g.PeakPlayers == games.Max(h => h.PeakPlayers)).First();
            Console.WriteLine("Game with most players (alternate query): " + query14a + "\n");

            // Question 15: Select all the games with peak players lower than average number of peak players (just in Method Syntax).
            var query15 = games.Where(g => g.PeakPlayers < games.Average(h => h.PeakPlayers));
            Console.WriteLine($"Query 15: Games with peak players lower than the average. {query15.Count()} results.");
            Console.WriteLine($"------------");
            foreach (Game g in query15)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine($"------------\n");
        }
    }
}
