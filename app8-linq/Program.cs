internal class Program
{
    private static void Main(string[] args)
    {
        // create an array of the 9 planet names
        string[] planets = {
            "mercury", "venus", "earth",
            "mars", "jupiter", "saturn",
            "uranus", "neptune", "pluto"
        };

        // loop through and print each name
        planets
            .ToList()
            .ForEach(p => Console.WriteLine(p));
        Console.WriteLine(new string('-', 15));
        
        // loop through and print each name and its length
        planets
            .ToList()
            .ForEach(p => Console.WriteLine($"{p}, {p.Length}"));
        Console.WriteLine(new string('-', 15));

        // use a loop to add all the lengths of the planet names
        // print the total out
        int total = 0;
        foreach (var p in planets) {
            var len = p.Length;
            total += len;
        }
        Console.WriteLine($"total = {total}");
        Console.WriteLine(new string('-', 15));

        // easier
        total = planets
            .ToList()
            .Select(p => p.Length)
            .Sum();

        Console.WriteLine($"total={total}");
        Console.WriteLine(new string('-', 15));

        total = planets
            .ToList()
            .Where(p => !p.StartsWith("e"))
            .Select(p => p.Length)
            .Sum();
        Console.WriteLine($"total={total}");
        Console.WriteLine(new string('-', 15));
    }
}