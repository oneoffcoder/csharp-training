internal class Program
{
    private static void Main(string[] args)
    {
        // create an array of the names (first and last only)
        // of the first 10 presidents
        // what is the lengths of each of their name?
        // what is the sum of the lengths of their name?
        // use LINQ to find the president with the shortest name
        // use LINQ to find the president with the longest name

        string[] presidents = {
            "george washington", "john adams", 
            "thomas jefferson", "james madison",
            "james monroe", "john adams",
            "andrew jackson", "martin van buren",
            "william harrison", "john tyler"
        };

        // name lengths
        presidents
            .ToList()
            .ForEach(p => Console.WriteLine($"{p}, {p.Length}"));
        Console.WriteLine(new String('-', 15));

        // sum
        var n = presidents
            .ToList()
            .Select(p => p.Length)
            .Sum();
        Console.WriteLine($"sum of lengths = {n}");
        Console.WriteLine(new String('-', 15));

        // shortest
        var shortest = presidents
            .ToList()
            .OrderBy(p => p.Length)
            .First();
        var longest = presidents
            .ToList()
            .OrderByDescending(p => p.Length)
            .First();
        Console.WriteLine($"shortest = {shortest}, longest = {longest}");
        Console.WriteLine(new String('-', 15));

        // print the names from shortest length to longest
        presidents
            .ToList()
            .OrderBy(p => p.Length)
            .ToList()
            .ForEach(p => Console.WriteLine(p));
        Console.WriteLine(new String('-', 15));

        // print the names from longest length to shortest
        presidents
            .ToList()
            .OrderByDescending(p => p.Length)
            .ToList()
            .ForEach(p => Console.WriteLine($"*{p}"));
    }

    static void DoElementExerices() {
        // create an array of the first 10 atomic elements
        // what is the sum of the lengths of the first 10 atomic elements' names?
        string[] elements = {
            "Hydrogen", "Helium", "Lithium",
            "Boron", "Carbon"
        };

        var sum = elements
            .ToList()
            .Select(e => e.Length)
            .Sum();
        Console.WriteLine($"sum is {sum}");
    }

    static void DoPlanetExercise() {
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