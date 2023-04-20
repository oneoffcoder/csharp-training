internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("light: ");
        var light = Console.ReadLine();

        if (light is not null) {
            if (light.ToLower().Equals("red")) {
                Console.WriteLine("stop");
            } else if (light.ToLower().Equals("yellow")) {
                Console.WriteLine("slow");
            } else if (light.ToLower().Equals("green")) {
                Console.WriteLine("go");
            } else {
                Console.WriteLine($"I don't know the color {light}");
            }
        }
    }
}