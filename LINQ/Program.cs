using System.Linq;
Console.WriteLine("Video game collection");

List<string> videoGames = new List<string>{"Resident Evil 4", "Assassin's Creed Revelations", "Watch Dogs", "Dishonored" };
var orderedVideoGames = videoGames.OrderBy(x => x.Length).ToList();

videoGames.ForEach(videoGame =>  Console.WriteLine(videoGame));
Console.WriteLine("__________________");
orderedVideoGames.ForEach(videoGame =>  Console.WriteLine(videoGame));