using Coder.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Human h1 = new Human("John", "Wick");
        Human h2 = new Human("Jack", "Sparrow");

        Console.WriteLine($"{h1}, {h1.GetHashCode()}");
        Console.WriteLine($"{h2}, {h2.GetHashCode()}");
        Console.WriteLine($"{h1.Equals(h2)}");

        Pet[] pets = {
            new("Cat", "meow"),
            new("Dog", "woof")
        };

        pets.ToList().ForEach(p => Console.WriteLine(p));
    }
}