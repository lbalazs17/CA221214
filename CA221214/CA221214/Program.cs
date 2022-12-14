using CA221214;
List <Game> games = new();
using StreamReader sr = new("..\\..\\..\\res\\bestgames.csv");
Random rnd = new Random(); 
while (!sr.EndOfStream)
{
    games.Add(new Game(sr.ReadLine()));
}
Console.WriteLine($"f1: Összesen {games.Count} játék szerepel a listában!");

Console.WriteLine("f2: ezekben az években került a legtöbb játék listára:");
var grp = games.GroupBy(x => x.ReleaseYear)
    .Where(x => x.Count() > 10)
    .OrderByDescending(x => x.Count());
foreach (var ytg in grp)
{
    Console.WriteLine($"\t{ytg.Key}: {ytg.Count()}db");
}
var fpss = games.Where(x => x.Genre == "First-person shooter").ToList();
Console.WriteLine($"f3: összesen {fpss.Count} FPS került a listára! + " +
    $"\n\tpéldául: {fpss[rnd.Next(fpss.Count)].Title}");
//Dictionary<int, int> dic = new();
//foreach (Game g in games)
//{
//    if (!dic.ContainsKey(g.ReleaseYear))
//    {
//        dic.Add(g.ReleaseYear, 1);
//    }
//    else dic[g.ReleaseYear]++;
//}
//var kvpl = dic.ToList();
//for (int i = 0; i < kvpl.Count-1; i++)
//{
//    for (int j = i+1; j < kvpl.Count; j++)
//    {
//        if (kvpl[j].Value > kvpl[i].Value)
//        {
//            kvpl[i],kvpl[j] = (kvpl[j]);

//        }
//    }
//}
//foreach (var kvp in kvpl)
//{
//    if (kvp.Value>10)
//    {
//        Console.WriteLine($"{kvp.Key}: {kvp.Value}db");
//    }
//}