internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = {
            "john", "jack", "mary", "mandy"
        };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.WriteLine(new string('-', 15));

        foreach (var n in names)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine(new string('-', 15));

        names.ToList().ForEach(n => Console.WriteLine(n));
        Console.WriteLine(new string('-', 15));
    }
}