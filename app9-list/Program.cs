internal class Program
{
    private static void Main(string[] args)
    {
        var names = new List<string> {"john", "jack", "jeff", "jeremy", "jason"};
        var nameLengths = names.Select(name => name.Length);
        var firstLetters = names.Select(name => name[0]);

        foreach(var length in nameLengths) {
            Console.WriteLine(length);
        }

        Console.WriteLine(new String('-', 15));

        foreach(var letter in firstLetters) {
            Console.WriteLine(letter);
        }
    }

    private static void example3() {
        var names = new List<string> {"john", "jack", "jeff", "jeremy", "jason"};
        names.Sort();

        foreach(var name in names) {
            Console.WriteLine(name);
        }
    }

    private static void example2() {
        var names = new List<string> {"john", "jack", "jeff", "jeremy", "jason"};
        foreach(var name in names) {
            Console.WriteLine(name);
        }
    }

    private static void example1() {
        var names = new List<string>();
        names.Add("john");
        names.Add("jack");
        names.Add("jeff");
        names.Add("jeremy");
        names.Add("jason");
        
        foreach(var name in names) {
            Console.WriteLine(name);
        }
    }
}