using Coder.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        HumanClazz h1 = new HumanClazz("John", "Wick");
        HumanClazz h2 = new HumanClazz("John", "Wick");
        HumanClazz h3 = new HumanClazz("Jack", "Sparrow");

        Console.WriteLine($"{h1}, {h1.GetHashCode()}");
        Console.WriteLine($"{h2}, {h2.GetHashCode()}");
        Console.WriteLine($"{h3}, {h3.GetHashCode()}");
        Console.WriteLine($"{h1.Equals(h2)}");
        Console.WriteLine($"{h1.Equals(h3)}");

        Console.WriteLine(new string('-', 15));

        HumanStruct h4 = new HumanStruct("John", "Wick");
        HumanStruct h5 = new HumanStruct("John", "Wick");
        HumanStruct h6 = new HumanStruct("Jack", "Sparrow");

        Console.WriteLine($"{h4}, {h4.GetHashCode()}");
        Console.WriteLine($"{h5}, {h5.GetHashCode()}");
        Console.WriteLine($"{h6}, {h6.GetHashCode()}");
        Console.WriteLine($"{h4.Equals(h5)}");
        Console.WriteLine($"{h5.Equals(h6)}");

        Console.WriteLine(new string('-', 15));

        HumanRecord h7 = new HumanRecord("John", "Wick");
        HumanRecord h8 = new HumanRecord("John", "Wick");
        HumanRecord h9 = new HumanRecord("Jack", "Sparrow");

        Console.WriteLine($"{h7}, {h7.GetHashCode()}");
        Console.WriteLine($"{h8}, {h8.GetHashCode()}");
        Console.WriteLine($"{h9}, {h9.GetHashCode()}");
        Console.WriteLine($"{h7.Equals(h8)}");
        Console.WriteLine($"{h7.Equals(h9)}");

        Console.WriteLine(new string('-', 15));

        Pet[] pets = {
            new("Cat", "meow"),
            new("Dog", "woof")
        };

        pets.ToList().ForEach(p => Console.WriteLine(p));
    }
}